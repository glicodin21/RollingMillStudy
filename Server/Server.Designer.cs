namespace Server
{
    partial class Server
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartBtn = new System.Windows.Forms.Button();
            this.HostL = new System.Windows.Forms.Label();
            this.HostTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.PortL = new System.Windows.Forms.Label();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.DepthTxt = new System.Windows.Forms.TextBox();
            this.DepthL = new System.Windows.Forms.Label();
            this.SourceDepthTxt = new System.Windows.Forms.TextBox();
            this.SorceDepthL = new System.Windows.Forms.Label();
            this.SpeedL = new System.Windows.Forms.Label();
            this.SpeedTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(221, 18);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // HostL
            // 
            this.HostL.AutoSize = true;
            this.HostL.Location = new System.Drawing.Point(12, 23);
            this.HostL.Name = "HostL";
            this.HostL.Size = new System.Drawing.Size(27, 13);
            this.HostL.TabIndex = 1;
            this.HostL.Text = "host";
            // 
            // HostTxt
            // 
            this.HostTxt.AcceptsReturn = true;
            this.HostTxt.AcceptsTab = true;
            this.HostTxt.AllowDrop = true;
            this.HostTxt.Location = new System.Drawing.Point(45, 20);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(88, 20);
            this.HostTxt.TabIndex = 2;
            this.HostTxt.Text = "127.0.0.1";
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(170, 20);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(33, 20);
            this.PortTxt.TabIndex = 4;
            this.PortTxt.Text = "2200";
            // 
            // PortL
            // 
            this.PortL.AutoSize = true;
            this.PortL.Location = new System.Drawing.Point(139, 23);
            this.PortL.Name = "PortL";
            this.PortL.Size = new System.Drawing.Size(25, 13);
            this.PortL.TabIndex = 3;
            this.PortL.Text = "port";
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(302, 18);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // StatusTxt
            // 
            this.StatusTxt.Location = new System.Drawing.Point(45, 46);
            this.StatusTxt.Multiline = true;
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(332, 60);
            this.StatusTxt.TabIndex = 6;
            // 
            // DepthTxt
            // 
            this.DepthTxt.Location = new System.Drawing.Point(45, 125);
            this.DepthTxt.Name = "DepthTxt";
            this.DepthTxt.Size = new System.Drawing.Size(332, 20);
            this.DepthTxt.TabIndex = 7;
            // 
            // DepthL
            // 
            this.DepthL.AutoSize = true;
            this.DepthL.Location = new System.Drawing.Point(189, 109);
            this.DepthL.Name = "DepthL";
            this.DepthL.Size = new System.Drawing.Size(53, 13);
            this.DepthL.TabIndex = 8;
            this.DepthL.Text = "Толщина";
            // 
            // SourceDepthTxt
            // 
            this.SourceDepthTxt.Location = new System.Drawing.Point(45, 168);
            this.SourceDepthTxt.Name = "SourceDepthTxt";
            this.SourceDepthTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SourceDepthTxt.Size = new System.Drawing.Size(332, 20);
            this.SourceDepthTxt.TabIndex = 9;
            // 
            // SorceDepthL
            // 
            this.SorceDepthL.AutoSize = true;
            this.SorceDepthL.Location = new System.Drawing.Point(162, 152);
            this.SorceDepthL.Name = "SorceDepthL";
            this.SorceDepthL.Size = new System.Drawing.Size(103, 13);
            this.SorceDepthL.TabIndex = 10;
            this.SorceDepthL.Text = "Исходная толщина";
            // 
            // SpeedL
            // 
            this.SpeedL.AutoSize = true;
            this.SpeedL.Location = new System.Drawing.Point(162, 196);
            this.SpeedL.Name = "SpeedL";
            this.SpeedL.Size = new System.Drawing.Size(108, 13);
            this.SpeedL.TabIndex = 12;
            this.SpeedL.Text = "Скорость движения";
            // 
            // SpeedTxt
            // 
            this.SpeedTxt.Location = new System.Drawing.Point(45, 212);
            this.SpeedTxt.Name = "SpeedTxt";
            this.SpeedTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpeedTxt.Size = new System.Drawing.Size(332, 20);
            this.SpeedTxt.TabIndex = 11;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 272);
            this.Controls.Add(this.SpeedL);
            this.Controls.Add(this.SpeedTxt);
            this.Controls.Add(this.SorceDepthL);
            this.Controls.Add(this.SourceDepthTxt);
            this.Controls.Add(this.DepthL);
            this.Controls.Add(this.DepthTxt);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.PortL);
            this.Controls.Add(this.HostTxt);
            this.Controls.Add(this.HostL);
            this.Controls.Add(this.StartBtn);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label HostL;
        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label PortL;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox StatusTxt;
        public System.Windows.Forms.TextBox HostTxt;
        private System.Windows.Forms.TextBox DepthTxt;
        private System.Windows.Forms.Label DepthL;
        private System.Windows.Forms.TextBox SourceDepthTxt;
        private System.Windows.Forms.Label SorceDepthL;
        private System.Windows.Forms.Label SpeedL;
        private System.Windows.Forms.TextBox SpeedTxt;
    }
}

