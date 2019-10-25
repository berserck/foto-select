namespace foto_select
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelOriginFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelDestFolder1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelDestFolder2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelCurFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.originToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destination1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destination2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabelSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelFileCounter = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelOriginFolder,
            this.statusLabelDestFolder1,
            this.statusLabelDestFolder2,
            this.statusLabelCurFile,
            this.statusLabelSpacer,
            this.statusLabelFileCounter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.statusLabelOriginFolder.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusLabelOriginFolder.Name = "toolStripStatusLabel1";
            this.statusLabelOriginFolder.Size = new System.Drawing.Size(73, 19);
            this.statusLabelOriginFolder.Text = "O:<empty>";
            // 
            // toolStripStatusLabel2
            // 
            this.statusLabelDestFolder1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusLabelDestFolder1.Name = "toolStripStatusLabel2";
            this.statusLabelDestFolder1.Size = new System.Drawing.Size(78, 19);
            this.statusLabelDestFolder1.Text = "D1:<empty>";
            // 
            // toolStripStatusLabel3
            // 
            this.statusLabelDestFolder2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusLabelDestFolder2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabelDestFolder2.Name = "toolStripStatusLabel3";
            this.statusLabelDestFolder2.Size = new System.Drawing.Size(78, 19);
            this.statusLabelDestFolder2.Text = "D2:<empty>";
            // 
            // toolStripStatusLabel4
            // 
            this.statusLabelCurFile.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabelCurFile.Name = "toolStripStatusLabel4";
            this.statusLabelCurFile.Size = new System.Drawing.Size(0, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originToolStripMenuItem,
            this.destination1ToolStripMenuItem,
            this.destination2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // originToolStripMenuItem
            // 
            this.originToolStripMenuItem.Name = "originToolStripMenuItem";
            this.originToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.originToolStripMenuItem.Text = "Origin";
            this.originToolStripMenuItem.Click += new System.EventHandler(this.SelectOriginToolStripMenuItem_Click);
            // 
            // destination1ToolStripMenuItem
            // 
            this.destination1ToolStripMenuItem.Name = "destination1ToolStripMenuItem";
            this.destination1ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.destination1ToolStripMenuItem.Text = "Destination1";
            this.destination1ToolStripMenuItem.Click += new System.EventHandler(this.selectDest1ToolStripMenuItem_Click);
            // 
            // destination2ToolStripMenuItem
            // 
            this.destination2ToolStripMenuItem.Name = "destination2ToolStripMenuItem";
            this.destination2ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.destination2ToolStripMenuItem.Text = "Destination2";
            this.destination2ToolStripMenuItem.Click += new System.EventHandler(this.selectDest2ToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.statusLabelSpacer.Name = "toolStripStatusLabel5";
            this.statusLabelSpacer.Size = new System.Drawing.Size(407, 19);
            this.statusLabelSpacer.Spring = true;
            // 
            // toolStripStatusLabel6
            // 
            this.statusLabelFileCounter.Name = "toolStripStatusLabel6";
            this.statusLabelFileCounter.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOriginFolder;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDestFolder1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDestFolder2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem originToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destination1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destination2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelCurFile;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSpacer;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFileCounter;
    }
}

