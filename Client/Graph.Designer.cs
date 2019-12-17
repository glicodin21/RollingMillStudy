namespace Client
{
    partial class Graph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ZG1 = new ZedGraph.ZedGraphControl();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ZG1
            // 
            this.ZG1.Location = new System.Drawing.Point(-9, 1);
            this.ZG1.Name = "ZG1";
            this.ZG1.ScrollGrace = 0D;
            this.ZG1.ScrollMaxX = 0D;
            this.ZG1.ScrollMaxY = 0D;
            this.ZG1.ScrollMaxY2 = 0D;
            this.ZG1.ScrollMinX = 0D;
            this.ZG1.ScrollMinY = 0D;
            this.ZG1.ScrollMinY2 = 0D;
            this.ZG1.Size = new System.Drawing.Size(817, 455);
            this.ZG1.TabIndex = 0;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZG1);
            this.Name = "Graph";
            this.Text = "График";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl ZG1;
        private System.Windows.Forms.Timer Timer;
    }
}