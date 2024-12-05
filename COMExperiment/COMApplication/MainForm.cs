using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMLibrary;

namespace COMApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                IExpress express = new Express();
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                string minusResult = express.minus(a, b);
                string divideResult = express.divide(a, b);

                lblResult.Text = $"Minus: {minusResult}\nDivide: {divideResult}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
