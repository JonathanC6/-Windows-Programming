namespace ProcessCommunication
{
    partial class CommunicationForm
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
            this.textBoxSyncIP = new System.Windows.Forms.TextBox();
            this.btnSyncPing = new System.Windows.Forms.Button();
            this.textBoxSyncResult = new System.Windows.Forms.TextBox();
            this.textBoxAsyncIP = new System.Windows.Forms.TextBox();
            this.btnAsyncPing = new System.Windows.Forms.Button();
            this.textBoxAsyncResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSyncIP
            // 
            this.textBoxSyncIP.Location = new System.Drawing.Point(12, 12);
            this.textBoxSyncIP.Name = "textBoxSyncIP";
            this.textBoxSyncIP.Size = new System.Drawing.Size(250, 40);
            this.textBoxSyncIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxSyncIP.TabIndex = 0;
            // 
            // btnSyncPing
            // 
            this.btnSyncPing.Location = new System.Drawing.Point(270, 12);
            this.btnSyncPing.Name = "btnSyncPing";
            this.btnSyncPing.Size = new System.Drawing.Size(140, 40);
            this.btnSyncPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSyncPing.TabIndex = 1;
            this.btnSyncPing.Text = "Ping (同步)";
            this.btnSyncPing.UseVisualStyleBackColor = true;
            this.btnSyncPing.Click += new System.EventHandler(this.btnSyncPing_Click);
            // 
            // textBoxSyncResult
            // 
            this.textBoxSyncResult.Location = new System.Drawing.Point(12, 60);
            this.textBoxSyncResult.Multiline = true;
            this.textBoxSyncResult.Name = "textBoxSyncResult";
            this.textBoxSyncResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSyncResult.Size = new System.Drawing.Size(400, 400);
            this.textBoxSyncResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSyncResult.TabIndex = 2;
            // 
            // textBoxAsyncIP
            // 
            this.textBoxAsyncIP.Location = new System.Drawing.Point(430, 12);
            this.textBoxAsyncIP.Name = "textBoxAsyncIP";
            this.textBoxAsyncIP.Size = new System.Drawing.Size(250, 40);
            this.textBoxAsyncIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxAsyncIP.TabIndex = 3;
            // 
            // btnAsyncPing
            // 
            this.btnAsyncPing.Location = new System.Drawing.Point(690, 12);
            this.btnAsyncPing.Name = "btnAsyncPing";
            this.btnAsyncPing.Size = new System.Drawing.Size(140, 40);
            this.btnAsyncPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAsyncPing.TabIndex = 4;
            this.btnAsyncPing.Text = "Ping (异步)";
            this.btnAsyncPing.UseVisualStyleBackColor = true;
            this.btnAsyncPing.Click += new System.EventHandler(this.btnAsyncPing_Click);
            // 
            // textBoxAsyncResult
            // 
            this.textBoxAsyncResult.Location = new System.Drawing.Point(430, 60);
            this.textBoxAsyncResult.Multiline = true;
            this.textBoxAsyncResult.Name = "textBoxAsyncResult";
            this.textBoxAsyncResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAsyncResult.Size = new System.Drawing.Size(400, 400);
            this.textBoxAsyncResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxAsyncResult.TabIndex = 5;
            // 
            // CommunicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.textBoxAsyncResult);
            this.Controls.Add(this.btnAsyncPing);
            this.Controls.Add(this.textBoxAsyncIP);
            this.Controls.Add(this.textBoxSyncResult);
            this.Controls.Add(this.btnSyncPing);
            this.Controls.Add(this.textBoxSyncIP);
            this.Name = "CommunicationForm";
            this.Text = "进程同步异步通信";
            this.Load += new System.EventHandler(this.CommunicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSyncIP;
        private System.Windows.Forms.Button btnSyncPing;
        private System.Windows.Forms.TextBox textBoxSyncResult;
        private System.Windows.Forms.TextBox textBoxAsyncIP;
        private System.Windows.Forms.Button btnAsyncPing;
        private System.Windows.Forms.TextBox textBoxAsyncResult;
    }
}
