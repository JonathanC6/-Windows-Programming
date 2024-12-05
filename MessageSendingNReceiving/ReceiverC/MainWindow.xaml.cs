using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CopyDataStruct;

namespace ReceiverC
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Title = "ReceiverC";
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            HwndSource hwndSource = HwndSource.FromHwnd(new WindowInteropHelper(this).Handle);
            hwndSource.AddHook(new HwndSourceHook(WndProc));
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (msg == MessageTypes.WM_COPYDATA)
            {
                COPYDATASTRUCT copyData = (COPYDATASTRUCT)Marshal.PtrToStructure(lParam, typeof(COPYDATASTRUCT));
                byte[] receivedBytes = new byte[copyData.cbData];
                Marshal.Copy(copyData.lpData, receivedBytes, 0, copyData.cbData);
                string receivedMessage = Encoding.Default.GetString(receivedBytes);
                listBoxMessages.Items.Add($"Received: {receivedMessage} at {DateTime.Now}");
                handled = true;
            }
            return IntPtr.Zero;
        }
    }
}
