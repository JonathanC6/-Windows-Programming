using System.Drawing;

namespace CallDLL
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCallDLL = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblFactorialResult = new System.Windows.Forms.Label();
            this.lblDifferenceResult = new System.Windows.Forms.Label();
            this.groupBoxFactorial = new System.Windows.Forms.GroupBox();
            this.groupBoxDifference = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnCallDLL
            // 
            this.btnCallDLL.Location = new System.Drawing.Point(120, 310);
            this.btnCallDLL.Name = "btnCallDLL";
            this.btnCallDLL.Size = new System.Drawing.Size(200, 40);
            this.btnCallDLL.TabIndex = 0;
            this.btnCallDLL.Text = "调用 DLL";
            this.btnCallDLL.UseVisualStyleBackColor = true;
            this.btnCallDLL.Click += new System.EventHandler(this.btnCallDLL_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 25);
            this.txtInput.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(24, 33);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(90, 15);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "输入一个数:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(91, 80);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 15);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "a:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(120, 77);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(80, 25);
            this.txtA.TabIndex = 4;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(211, 80);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(23, 15);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "b:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(240, 77);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(80, 25);
            this.txtB.TabIndex = 6;
            // 
            // groupBoxFactorial
            // 
            this.groupBoxFactorial.Controls.Add(this.lblFactorialResult);
            this.groupBoxFactorial.Location = new System.Drawing.Point(30, 120);
            this.groupBoxFactorial.Name = "groupBoxFactorial";
            this.groupBoxFactorial.Size = new System.Drawing.Size(340, 80);
            this.groupBoxFactorial.TabIndex = 7;
            this.groupBoxFactorial.TabStop = false;
            this.groupBoxFactorial.Text = "阶乘结果";
            // 
            // lblFactorialResult
            // 
            this.lblFactorialResult.AutoSize = true;
            this.lblFactorialResult.Location = new System.Drawing.Point(20, 35);
            this.lblFactorialResult.Name = "lblFactorialResult";
            this.lblFactorialResult.Size = new System.Drawing.Size(0, 15);
            this.lblFactorialResult.TabIndex = 8;
            // 
            // groupBoxDifference
            // 
            this.groupBoxDifference.Controls.Add(this.lblDifferenceResult);
            this.groupBoxDifference.Location = new System.Drawing.Point(30, 210);
            this.groupBoxDifference.Name = "groupBoxDifference";
            this.groupBoxDifference.Size = new System.Drawing.Size(340, 80);
            this.groupBoxDifference.TabIndex = 9;
            this.groupBoxDifference.TabStop = false;
            this.groupBoxDifference.Text = "差值结果";
            // 
            // lblDifferenceResult
            // 
            this.lblDifferenceResult.AutoSize = true;
            this.lblDifferenceResult.Location = new System.Drawing.Point(20, 35);
            this.lblDifferenceResult.Name = "lblDifferenceResult";
            this.lblDifferenceResult.Size = new System.Drawing.Size(0, 15);
            this.lblDifferenceResult.TabIndex = 10;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.groupBoxDifference);
            this.Controls.Add(this.groupBoxFactorial);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCallDLL);
            this.Name = "MainForm";
            this.Text = "调用 C++ DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallDLL;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblFactorialResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblDifferenceResult;
        private System.Windows.Forms.GroupBox groupBoxFactorial;
        private System.Windows.Forms.GroupBox groupBoxDifference;
    }
}

