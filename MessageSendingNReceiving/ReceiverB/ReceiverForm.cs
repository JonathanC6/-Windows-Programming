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

namespace ReceiverB
{
    public partial class ReceiverForm : Form
    {
        public ReceiverForm()
        {
            InitializeComponent();
            this.Text = "ReceiverB";
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == MessageTypes.WM_COPYDATA)
            {
                COPYDATASTRUCT copyData = (COPYDATASTRUCT)Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
                byte[] receivedBytes = new byte[copyData.cbData];
                Marshal.Copy(copyData.lpData, receivedBytes, 0, copyData.cbData);
                string receivedMessage = Encoding.Default.GetString(receivedBytes);

                //将接收到的消息和时间添加到ListBox
                listBoxMessages.Items.Add($"Received: {receivedMessage} at {DateTime.Now}");
            }
            else
            {
                base.WndProc(ref m); //确保调用基类方法
            }
        }
    }
}
