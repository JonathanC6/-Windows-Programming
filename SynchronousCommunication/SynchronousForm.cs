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

namespace SynchronousCommunication
{
    public partial class SynchronousForm : Form
    {
        public SynchronousForm()
        {
            InitializeComponent();
        }

        private void SynchronousForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "请输入指定的IP";
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            //获取用户输入的 IP 地址，若为空或为提示文本则使用默认网址
            string ipAddress = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(ipAddress) || ipAddress == "请输入指定的IP")
            {
                //默认地址
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

            //读取输出结果
            string output = pingProcess.StandardOutput.ReadToEnd();

            pingProcess.WaitForExit();

            textBox2.Text = output;
        }
    }
}
