using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyDataStruct;

namespace SenderA
{
    public partial class SenderForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        public SenderForm()
        {
            InitializeComponent();
        }

        private void btnSendMessage1_Click(object sender, EventArgs e)
        {
            SendMessageTo("ReceiverB");
        }

        private void btnSendMessage2_Click(object sender, EventArgs e)
        {
            SendMessageTo("ReceiverC");
        }

        private void SendMessageTo(string windowName)
        {
            IntPtr hWndReceiver = FindWindow(null, windowName);
            if (hWndReceiver == IntPtr.Zero)
            {
                MessageBox.Show("未找到接收者窗口");
                return;
            }

            string message = txtMessage.Text;
            byte[] messageBytes = Encoding.Default.GetBytes(message);

            COPYDATASTRUCT copyData = new COPYDATASTRUCT();
            copyData.dwData = IntPtr.Zero;
            copyData.cbData = messageBytes.Length;
            copyData.lpData = Marshal.UnsafeAddrOfPinnedArrayElement(messageBytes, 0);

            SendMessage(hWndReceiver, MessageTypes.WM_COPYDATA, IntPtr.Zero, ref copyData);
        }
    }
}
