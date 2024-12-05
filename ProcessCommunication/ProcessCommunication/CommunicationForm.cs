using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessCommunication
{
    public partial class CommunicationForm : Form
    {
        public CommunicationForm()
        {
            InitializeComponent();
        }

        private void CommunicationForm_Load(object sender, EventArgs e)
        {
            textBoxSyncIP.Text = "请输入指定的IP (同步)";
            textBoxAsyncIP.Text = "请输入指定的IP (异步)";
        }

        /*----------同步通信按钮点击事件----------*/
        private void btnSyncPing_Click(object sender, EventArgs e)
        {
            string ipAddress = textBoxSyncIP.Text.Trim();
            if (string.IsNullOrEmpty(ipAddress) || ipAddress == "请输入指定的IP (同步)")
            {
                ipAddress = "www.sohu.com";
            }

            string pingCommand = $"ping {ipAddress} -n 10";
            Process pingProcess = new Process();

            pingProcess.StartInfo.FileName = "cmd.exe";
            pingProcess.StartInfo.RedirectStandardInput = true;
            pingProcess.StartInfo.RedirectStandardOutput = true;
            pingProcess.StartInfo.RedirectStandardError = true;
            pingProcess.StartInfo.UseShellExecute = false;
            pingProcess.StartInfo.CreateNoWindow = true;

            pingProcess.Start();

            using (StreamWriter sw = pingProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(pingCommand);
                    sw.WriteLine("exit");
                }
            }

            string output = pingProcess.StandardOutput.ReadToEnd();
            pingProcess.WaitForExit();

            textBoxSyncResult.Text = output;
        }

        /*----------异步通信按钮点击事件----------*/
        private void btnAsyncPing_Click(object sender, EventArgs e)
        {
            string ipAddress = textBoxAsyncIP.Text.Trim();
            if (string.IsNullOrEmpty(ipAddress) || ipAddress == "请输入指定的IP (异步)")
            {
                ipAddress = "www.sohu.com";
            }

            string pingCommand = $"ping {ipAddress} -n 10";
            Process pingProcess = new Process();

            pingProcess.StartInfo.FileName = "cmd.exe";
            pingProcess.StartInfo.RedirectStandardInput = true;
            pingProcess.StartInfo.RedirectStandardOutput = true;
            pingProcess.StartInfo.RedirectStandardError = true;
            pingProcess.StartInfo.UseShellExecute = false;  //不使用shell
            pingProcess.StartInfo.CreateNoWindow = true;    //不创建新的窗口

            //订阅输出事件并启动进程
            pingProcess.OutputDataReceived += new DataReceivedEventHandler(Process_OutputDataReceived);
            pingProcess.Start();
            pingProcess.BeginOutputReadLine();

            using (StreamWriter sw = pingProcess.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(pingCommand);
                    sw.WriteLine("exit");
                }
            }
        }

        //异步读取输出流时的回调函数
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                this.Invoke((MethodInvoker)delegate
                {
                    textBoxAsyncResult.AppendText(e.Data + Environment.NewLine);
                });
            }
        }
    }
}
