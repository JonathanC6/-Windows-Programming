namespace SenderA
{
    partial class SenderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage1 = new System.Windows.Forms.Button();
            this.btnSendMessage2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(288, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送内容";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(224, 108);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(350, 200);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSendMessage1
            // 
            this.btnSendMessage1.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSendMessage1.Location = new System.Drawing.Point(224, 347);
            this.btnSendMessage1.Name = "btnSendMessage1";
            this.btnSendMessage1.Size = new System.Drawing.Size(150, 40);
            this.btnSendMessage1.TabIndex = 2;
            this.btnSendMessage1.Text = "触发消息1";
            this.btnSendMessage1.UseVisualStyleBackColor = true;
            this.btnSendMessage1.Click += new System.EventHandler(this.btnSendMessage1_Click);
            // 
            // btnSendMessage2
            // 
            this.btnSendMessage2.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSendMessage2.Location = new System.Drawing.Point(424, 347);
            this.btnSendMessage2.Name = "btnSendMessage2";
            this.btnSendMessage2.Size = new System.Drawing.Size(150, 40);
            this.btnSendMessage2.TabIndex = 3;
            this.btnSendMessage2.Text = "触发消息2";
            this.btnSendMessage2.UseVisualStyleBackColor = true;
            this.btnSendMessage2.Click += new System.EventHandler(this.btnSendMessage2_Click);
            // 
            // SenderForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSendMessage2);
            this.Controls.Add(this.btnSendMessage1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Name = "SenderForm";
            this.Text = "SenderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSendMessage1;
        private System.Windows.Forms.Button btnSendMessage2;
    }
}

