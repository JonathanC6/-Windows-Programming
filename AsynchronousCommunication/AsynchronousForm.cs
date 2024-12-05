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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AsynchronousCommunication
{
    public partial class AsynchronousForm : Form
    {
        public AsynchronousForm()
        {
            InitializeComponent();
        }

        private void AsynchronousForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "请输入指定的IP";
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            //获取用户输入的 IP 地址，若为空或为提示文本则使用默认网址
            string ipAddress = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(ipAddress) || ipAddress == "请输入指定的IP")
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

            //订阅输出事件
            pingProcess.OutputDataReceived += new DataReceivedEventHandler(Process_OutputDataReceived);

            pingProcess.Start();

            //开始异步读取输出流
            pingProcess.BeginOutputReadLine();

            //向 cmd 进程的标准输入流中写入 ping 命令
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
                //更新 UI，需要在主线程上进行
                this.Invoke((MethodInvoker)delegate
                {
                    //在每次接收到数据时将其追加到 textBox2 中
                    textBox2.AppendText(e.Data + Environment.NewLine);
                });
            }
        }
    }
}
