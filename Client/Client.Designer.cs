namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.PortL = new System.Windows.Forms.Label();
            this.HostTxt = new System.Windows.Forms.TextBox();
            this.HostL = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DepthL = new System.Windows.Forms.Label();
            this.DepthBoxTxt = new System.Windows.Forms.TextBox();
            this.DepthBtn = new System.Windows.Forms.Button();
            this.SourceDepthL = new System.Windows.Forms.Label();
            this.SourceDepthBoxTxt = new System.Windows.Forms.TextBox();
            this.SpeedBoxTxt = new System.Windows.Forms.TextBox();
            this.SpeedBtn = new System.Windows.Forms.Button();
            this.SpeedL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(175, 11);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(33, 20);
            this.PortTxt.TabIndex = 9;
            this.PortTxt.Text = "2200";
            // 
            // PortL
            // 
            this.PortL.AutoSize = true;
            this.PortL.Location = new System.Drawing.Point(144, 15);
            this.PortL.Name = "PortL";
            this.PortL.Size = new System.Drawing.Size(25, 13);
            this.PortL.TabIndex = 8;
            this.PortL.Text = "port";
            // 
            // HostTxt
            // 
            this.HostTxt.Location = new System.Drawing.Point(38, 12);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(100, 20);
            this.HostTxt.TabIndex = 7;
            this.HostTxt.Text = "127.0.0.1";
            // 
            // HostL
            // 
            this.HostL.AutoSize = true;
            this.HostL.Location = new System.Drawing.Point(5, 15);
            this.HostL.Name = "HostL";
            this.HostL.Size = new System.Drawing.Size(27, 13);
            this.HostL.TabIndex = 6;
            this.HostL.Text = "host";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(8, 38);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(200, 36);
            this.ConnectBtn.TabIndex = 5;
            this.ConnectBtn.Text = "Подключится";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectClickBtn);
            // 
            // DepthL
            // 
            this.DepthL.AutoSize = true;
            this.DepthL.Location = new System.Drawing.Point(584, 106);
            this.DepthL.Name = "DepthL";
            this.DepthL.Size = new System.Drawing.Size(53, 13);
            this.DepthL.TabIndex = 13;
            this.DepthL.Text = "Толщина";
            // 
            // DepthBoxTxt
            // 
            this.DepthBoxTxt.Location = new System.Drawing.Point(709, 103);
            this.DepthBoxTxt.Name = "DepthBoxTxt";
            this.DepthBoxTxt.Size = new System.Drawing.Size(39, 20);
            this.DepthBoxTxt.TabIndex = 14;
            // 
            // DepthBtn
            // 
            this.DepthBtn.Location = new System.Drawing.Point(770, 76);
            this.DepthBtn.Name = "DepthBtn";
            this.DepthBtn.Size = new System.Drawing.Size(75, 47);
            this.DepthBtn.TabIndex = 15;
            this.DepthBtn.Text = "Отправить";
            this.DepthBtn.UseVisualStyleBackColor = true;
            this.DepthBtn.Click += new System.EventHandler(this.btnTolsh_Click);
            // 
            // SourceDepthL
            // 
            this.SourceDepthL.AutoSize = true;
            this.SourceDepthL.Location = new System.Drawing.Point(584, 79);
            this.SourceDepthL.Name = "SourceDepthL";
            this.SourceDepthL.Size = new System.Drawing.Size(103, 13);
            this.SourceDepthL.TabIndex = 16;
            this.SourceDepthL.Text = "Исходная толщина";
            // 
            // SourceDepthBoxTxt
            // 
            this.SourceDepthBoxTxt.Location = new System.Drawing.Point(709, 76);
            this.SourceDepthBoxTxt.Name = "SourceDepthBoxTxt";
            this.SourceDepthBoxTxt.Size = new System.Drawing.Size(39, 20);
            this.SourceDepthBoxTxt.TabIndex = 18;
            // 
            // SpeedBoxTxt
            // 
            this.SpeedBoxTxt.Location = new System.Drawing.Point(709, 50);
            this.SpeedBoxTxt.Name = "SpeedBoxTxt";
            this.SpeedBoxTxt.Size = new System.Drawing.Size(39, 20);
            this.SpeedBoxTxt.TabIndex = 21;
            // 
            // SpeedBtn
            // 
            this.SpeedBtn.Location = new System.Drawing.Point(770, 48);
            this.SpeedBtn.Name = "SpeedBtn";
            this.SpeedBtn.Size = new System.Drawing.Size(75, 23);
            this.SpeedBtn.TabIndex = 20;
            this.SpeedBtn.Text = "Отправить";
            this.SpeedBtn.UseVisualStyleBackColor = true;
            this.SpeedBtn.Click += new System.EventHandler(this.SpeedBtn_Click);
            // 
            // SpeedL
            // 
            this.SpeedL.AutoSize = true;
            this.SpeedL.Location = new System.Drawing.Point(584, 53);
            this.SpeedL.Name = "SpeedL";
            this.SpeedL.Size = new System.Drawing.Size(108, 13);
            this.SpeedL.TabIndex = 19;
            this.SpeedL.Text = "Скорость движения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(708, 383);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // StatusTxt
            // 
            this.StatusTxt.Location = new System.Drawing.Point(8, 94);
            this.StatusTxt.Multiline = true;
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.ReadOnly = true;
            this.StatusTxt.Size = new System.Drawing.Size(200, 80);
            this.StatusTxt.TabIndex = 12;
            this.StatusTxt.TextChanged += new System.EventHandler(this.StatusTxt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 42);
            this.button1.TabIndex = 31;
            this.button1.Text = "Показать график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowButton);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(320, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(231, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Скорость:";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpeedBoxTxt);
            this.Controls.Add(this.SpeedBtn);
            this.Controls.Add(this.SpeedL);
            this.Controls.Add(this.SourceDepthBoxTxt);
            this.Controls.Add(this.SourceDepthL);
            this.Controls.Add(this.DepthBtn);
            this.Controls.Add(this.DepthBoxTxt);
            this.Controls.Add(this.DepthL);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.PortL);
            this.Controls.Add(this.HostTxt);
            this.Controls.Add(this.HostL);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.pictureBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortTxt;
        private System.Windows.Forms.Label PortL;
        private System.Windows.Forms.TextBox HostTxt;
        private System.Windows.Forms.Label HostL;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label DepthL;
        private System.Windows.Forms.TextBox DepthBoxTxt;
        private System.Windows.Forms.Button DepthBtn;
        private System.Windows.Forms.Label SourceDepthL;
        private System.Windows.Forms.TextBox SourceDepthBoxTxt;
        private System.Windows.Forms.TextBox SpeedBoxTxt;
        private System.Windows.Forms.Button SpeedBtn;
        private System.Windows.Forms.Label SpeedL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox StatusTxt;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

