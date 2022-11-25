namespace rgb_separation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGrayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetColorModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(788, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(382, 296);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 296);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(400, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(382, 296);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(12, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(382, 296);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveOutputToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toGrayscaleToolStripMenuItem,
            this.separateChannelsToolStripMenuItem,
            this.targetColorModelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toGrayscaleToolStripMenuItem
            // 
            this.toGrayscaleToolStripMenuItem.Name = "toGrayscaleToolStripMenuItem";
            this.toGrayscaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toGrayscaleToolStripMenuItem.Text = "To Grayscale";
            // 
            // separateChannelsToolStripMenuItem
            // 
            this.separateChannelsToolStripMenuItem.Name = "separateChannelsToolStripMenuItem";
            this.separateChannelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.separateChannelsToolStripMenuItem.Text = "Separate Channels";
            // 
            // targetColorModelToolStripMenuItem
            // 
            this.targetColorModelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yCbCrToolStripMenuItem,
            this.hSVToolStripMenuItem,
            this.labToolStripMenuItem});
            this.targetColorModelToolStripMenuItem.Name = "targetColorModelToolStripMenuItem";
            this.targetColorModelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.targetColorModelToolStripMenuItem.Text = "Target Color Model";
            // 
            // yCbCrToolStripMenuItem
            // 
            this.yCbCrToolStripMenuItem.CheckOnClick = true;
            this.yCbCrToolStripMenuItem.Name = "yCbCrToolStripMenuItem";
            this.yCbCrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yCbCrToolStripMenuItem.Text = "YCbCr";
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.CheckOnClick = true;
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            // 
            // labToolStripMenuItem
            // 
            this.labToolStripMenuItem.CheckOnClick = true;
            this.labToolStripMenuItem.Name = "labToolStripMenuItem";
            this.labToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labToolStripMenuItem.Text = "Lab";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 700);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem saveOutputToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toGrayscaleToolStripMenuItem;
        private ToolStripMenuItem separateChannelsToolStripMenuItem;
        private ToolStripMenuItem targetColorModelToolStripMenuItem;
        private ToolStripMenuItem yCbCrToolStripMenuItem;
        private ToolStripMenuItem hSVToolStripMenuItem;
        private ToolStripMenuItem labToolStripMenuItem;
    }
}