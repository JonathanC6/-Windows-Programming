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

namespace CallDLL
{
    public partial class MainForm : Form
    {
        //引用 DLL 中的 Factorial 函数
        [DllImport(@"D:\develop\CSProgram\Windows\DLLExperiment\x64\Release\CreateDLL.dll", 
        EntryPoint = "Factorial", SetLastError = true, CharSet = CharSet.Ansi,
        ExactSpelling = false, CallingConvention =
        CallingConvention.StdCall)]
        public static extern int Factorial(int n);

        //引用 DLL 中的 Difference 函数
        [DllImport(@"D:\develop\CSProgram\Windows\DLLExperiment\x64\Release\CreateDLL.dll",
        EntryPoint = "Difference", SetLastError = true, CharSet = CharSet.Ansi,
        ExactSpelling = false, CallingConvention =
        CallingConvention.StdCall)]
        public static extern int Difference(ref int a, ref int b);

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCallDLL_Click(object sender, EventArgs e)
        {
            //调用 Factorial 函数
            if (!int.TryParse(txtInput.Text, out int input))
            {
                MessageBox.Show("请输入有效的整数！");
                return;
            }

            int factorialResult = Factorial(input);
            lblFactorialResult.Text = $"{factorialResult}";

            //调用 Difference 函数
            if (!int.TryParse(txtA.Text, out int a) || !int.TryParse(txtB.Text, out int b))
            {
                MessageBox.Show("请输入有效的整数 a 和 b！");
                return;
            }

            int differenceResult = Difference(ref a, ref b);
            lblDifferenceResult.Text = $"(a = {a}, b = {b}) : {differenceResult}";
        }
    }
}
