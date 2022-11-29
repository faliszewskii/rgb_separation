using rgb_separation.model;

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
            this.thirdChannelImage = new System.Windows.Forms.PictureBox();
            this.firstChanelImage = new System.Windows.Forms.PictureBox();
            this.secondChannelImage = new System.Windows.Forms.PictureBox();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetColorModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.gammaInput = new System.Windows.Forms.TextBox();
            this.whiteYInput = new System.Windows.Forms.TextBox();
            this.blueYInput = new System.Windows.Forms.TextBox();
            this.greenYInput = new System.Windows.Forms.TextBox();
            this.whiteXInput = new System.Windows.Forms.TextBox();
            this.blueXInput = new System.Windows.Forms.TextBox();
            this.greenXInput = new System.Windows.Forms.TextBox();
            this.redXInput = new System.Windows.Forms.TextBox();
            this.redYInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.illuminantComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorProfileComboBox = new System.Windows.Forms.ComboBox();
            this.firstChannelLabel = new System.Windows.Forms.Label();
            this.secondChannelLabel = new System.Windows.Forms.Label();
            this.thirdChannelLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.thirdChannelImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstChanelImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondChannelImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.labSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // thirdChannelImage
            // 
            this.thirdChannelImage.BackColor = System.Drawing.SystemColors.Window;
            this.thirdChannelImage.Location = new System.Drawing.Point(788, 392);
            this.thirdChannelImage.Name = "thirdChannelImage";
            this.thirdChannelImage.Size = new System.Drawing.Size(382, 296);
            this.thirdChannelImage.TabIndex = 2;
            this.thirdChannelImage.TabStop = false;
            // 
            // firstChanelImage
            // 
            this.firstChanelImage.BackColor = System.Drawing.SystemColors.Window;
            this.firstChanelImage.Location = new System.Drawing.Point(12, 392);
            this.firstChanelImage.Name = "firstChanelImage";
            this.firstChanelImage.Size = new System.Drawing.Size(382, 296);
            this.firstChanelImage.TabIndex = 3;
            this.firstChanelImage.TabStop = false;
            // 
            // secondChannelImage
            // 
            this.secondChannelImage.BackColor = System.Drawing.SystemColors.Window;
            this.secondChannelImage.Location = new System.Drawing.Point(400, 392);
            this.secondChannelImage.Name = "secondChannelImage";
            this.secondChannelImage.Size = new System.Drawing.Size(382, 296);
            this.secondChannelImage.TabIndex = 4;
            this.secondChannelImage.TabStop = false;
            // 
            // sourceImage
            // 
            this.sourceImage.BackColor = System.Drawing.SystemColors.Window;
            this.sourceImage.Location = new System.Drawing.Point(12, 34);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(382, 296);
            this.sourceImage.TabIndex = 5;
            this.sourceImage.TabStop = false;
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
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.separateChannelsToolStripMenuItem,
            this.targetColorModelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // separateChannelsToolStripMenuItem
            // 
            this.separateChannelsToolStripMenuItem.Name = "separateChannelsToolStripMenuItem";
            this.separateChannelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.separateChannelsToolStripMenuItem.Text = "Separate Channels";
            this.separateChannelsToolStripMenuItem.Click += new System.EventHandler(this.separateChannelsToolStripMenuItem_Click);
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
            this.yCbCrToolStripMenuItem.Checked = true;
            this.yCbCrToolStripMenuItem.CheckOnClick = true;
            this.yCbCrToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yCbCrToolStripMenuItem.Name = "yCbCrToolStripMenuItem";
            this.yCbCrToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.yCbCrToolStripMenuItem.Text = "YCbCr";
            this.yCbCrToolStripMenuItem.Click += new System.EventHandler(this.yCbCrToolStripMenuItem_Click);
            // 
            // hSVToolStripMenuItem
            // 
            this.hSVToolStripMenuItem.CheckOnClick = true;
            this.hSVToolStripMenuItem.Name = "hSVToolStripMenuItem";
            this.hSVToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.hSVToolStripMenuItem.Text = "HSV";
            this.hSVToolStripMenuItem.Click += new System.EventHandler(this.hSVToolStripMenuItem_Click);
            // 
            // labToolStripMenuItem
            // 
            this.labToolStripMenuItem.CheckOnClick = true;
            this.labToolStripMenuItem.Name = "labToolStripMenuItem";
            this.labToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.labToolStripMenuItem.Text = "Lab";
            this.labToolStripMenuItem.Click += new System.EventHandler(this.labToolStripMenuItem_Click);
            // 
            // labSettingsGroupBox
            // 
            this.labSettingsGroupBox.Controls.Add(this.gammaInput);
            this.labSettingsGroupBox.Controls.Add(this.whiteYInput);
            this.labSettingsGroupBox.Controls.Add(this.blueYInput);
            this.labSettingsGroupBox.Controls.Add(this.greenYInput);
            this.labSettingsGroupBox.Controls.Add(this.whiteXInput);
            this.labSettingsGroupBox.Controls.Add(this.blueXInput);
            this.labSettingsGroupBox.Controls.Add(this.greenXInput);
            this.labSettingsGroupBox.Controls.Add(this.redXInput);
            this.labSettingsGroupBox.Controls.Add(this.redYInput);
            this.labSettingsGroupBox.Controls.Add(this.label10);
            this.labSettingsGroupBox.Controls.Add(this.label9);
            this.labSettingsGroupBox.Controls.Add(this.label8);
            this.labSettingsGroupBox.Controls.Add(this.label7);
            this.labSettingsGroupBox.Controls.Add(this.label6);
            this.labSettingsGroupBox.Controls.Add(this.label5);
            this.labSettingsGroupBox.Controls.Add(this.label4);
            this.labSettingsGroupBox.Controls.Add(this.label3);
            this.labSettingsGroupBox.Controls.Add(this.illuminantComboBox);
            this.labSettingsGroupBox.Controls.Add(this.label2);
            this.labSettingsGroupBox.Controls.Add(this.label1);
            this.labSettingsGroupBox.Controls.Add(this.colorProfileComboBox);
            this.labSettingsGroupBox.Enabled = false;
            this.labSettingsGroupBox.Location = new System.Drawing.Point(400, 34);
            this.labSettingsGroupBox.Name = "labSettingsGroupBox";
            this.labSettingsGroupBox.Size = new System.Drawing.Size(327, 296);
            this.labSettingsGroupBox.TabIndex = 7;
            this.labSettingsGroupBox.TabStop = false;
            this.labSettingsGroupBox.Text = "Lab settings";
            // 
            // gammaInput
            // 
            this.gammaInput.Location = new System.Drawing.Point(121, 256);
            this.gammaInput.Name = "gammaInput";
            this.gammaInput.Size = new System.Drawing.Size(97, 23);
            this.gammaInput.TabIndex = 29;
            this.gammaInput.TextChanged += new System.EventHandler(this.gammaInput_TextChanged);
            // 
            // whiteYInput
            // 
            this.whiteYInput.Location = new System.Drawing.Point(224, 228);
            this.whiteYInput.Name = "whiteYInput";
            this.whiteYInput.Size = new System.Drawing.Size(97, 23);
            this.whiteYInput.TabIndex = 28;
            this.whiteYInput.TextChanged += new System.EventHandler(this.whiteYInput_TextChanged);
            // 
            // blueYInput
            // 
            this.blueYInput.Location = new System.Drawing.Point(224, 198);
            this.blueYInput.Name = "blueYInput";
            this.blueYInput.Size = new System.Drawing.Size(97, 23);
            this.blueYInput.TabIndex = 27;
            this.blueYInput.TextChanged += new System.EventHandler(this.blueYInput_TextChanged);
            // 
            // greenYInput
            // 
            this.greenYInput.Location = new System.Drawing.Point(224, 169);
            this.greenYInput.Name = "greenYInput";
            this.greenYInput.Size = new System.Drawing.Size(97, 23);
            this.greenYInput.TabIndex = 26;
            this.greenYInput.TextChanged += new System.EventHandler(this.greenYInput_TextChanged);
            // 
            // whiteXInput
            // 
            this.whiteXInput.Location = new System.Drawing.Point(121, 227);
            this.whiteXInput.Name = "whiteXInput";
            this.whiteXInput.Size = new System.Drawing.Size(97, 23);
            this.whiteXInput.TabIndex = 25;
            this.whiteXInput.TextChanged += new System.EventHandler(this.whiteXInput_TextChanged);
            // 
            // blueXInput
            // 
            this.blueXInput.Location = new System.Drawing.Point(121, 198);
            this.blueXInput.Name = "blueXInput";
            this.blueXInput.Size = new System.Drawing.Size(97, 23);
            this.blueXInput.TabIndex = 24;
            this.blueXInput.TextChanged += new System.EventHandler(this.blueXInput_TextChanged);
            // 
            // greenXInput
            // 
            this.greenXInput.Location = new System.Drawing.Point(121, 169);
            this.greenXInput.Name = "greenXInput";
            this.greenXInput.Size = new System.Drawing.Size(97, 23);
            this.greenXInput.TabIndex = 23;
            this.greenXInput.TextChanged += new System.EventHandler(this.greenXInput_TextChanged);
            // 
            // redXInput
            // 
            this.redXInput.Location = new System.Drawing.Point(121, 140);
            this.redXInput.Name = "redXInput";
            this.redXInput.Size = new System.Drawing.Size(97, 23);
            this.redXInput.TabIndex = 22;
            this.redXInput.TextChanged += new System.EventHandler(this.redXInput_TextChanged);
            // 
            // redYInput
            // 
            this.redYInput.Location = new System.Drawing.Point(224, 140);
            this.redYInput.Name = "redYInput";
            this.redYInput.Size = new System.Drawing.Size(97, 23);
            this.redYInput.TabIndex = 21;
            this.redYInput.TextChanged += new System.EventHandler(this.redYInput_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Gamma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "White point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Blue primary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Green primary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Red primary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chromatisity";
            // 
            // illuminantComboBox
            // 
            this.illuminantComboBox.DisplayMember = "Name";
            this.illuminantComboBox.FormattingEnabled = true;
            this.illuminantComboBox.Location = new System.Drawing.Point(200, 53);
            this.illuminantComboBox.Name = "illuminantComboBox";
            this.illuminantComboBox.Size = new System.Drawing.Size(121, 23);
            this.illuminantComboBox.TabIndex = 3;
            this.illuminantComboBox.ValueMember = "PredefinedIlluminant";
            this.illuminantComboBox.SelectedIndexChanged += new System.EventHandler(this.illuminantComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predefined illuminant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Predefined color profile";
            // 
            // colorProfileComboBox
            // 
            this.colorProfileComboBox.DisplayMember = "Name";
            this.colorProfileComboBox.FormattingEnabled = true;
            this.colorProfileComboBox.Location = new System.Drawing.Point(200, 17);
            this.colorProfileComboBox.Name = "colorProfileComboBox";
            this.colorProfileComboBox.Size = new System.Drawing.Size(121, 23);
            this.colorProfileComboBox.TabIndex = 0;
            this.colorProfileComboBox.ValueMember = "PredefinedColorProfile";
            this.colorProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.colorProfileComboBox_SelectedIndexChanged);
            // 
            // firstChannelLabel
            // 
            this.firstChannelLabel.AutoSize = true;
            this.firstChannelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstChannelLabel.Location = new System.Drawing.Point(31, 356);
            this.firstChannelLabel.Name = "firstChannelLabel";
            this.firstChannelLabel.Size = new System.Drawing.Size(20, 21);
            this.firstChannelLabel.TabIndex = 8;
            this.firstChannelLabel.Text = "Y";
            // 
            // secondChannelLabel
            // 
            this.secondChannelLabel.AutoSize = true;
            this.secondChannelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondChannelLabel.Location = new System.Drawing.Point(406, 356);
            this.secondChannelLabel.Name = "secondChannelLabel";
            this.secondChannelLabel.Size = new System.Drawing.Size(30, 21);
            this.secondChannelLabel.TabIndex = 9;
            this.secondChannelLabel.Text = "Cb";
            // 
            // thirdChannelLabel
            // 
            this.thirdChannelLabel.AutoSize = true;
            this.thirdChannelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thirdChannelLabel.Location = new System.Drawing.Point(800, 356);
            this.thirdChannelLabel.Name = "thirdChannelLabel";
            this.thirdChannelLabel.Size = new System.Drawing.Size(26, 21);
            this.thirdChannelLabel.TabIndex = 10;
            this.thirdChannelLabel.Text = "Cr";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = true;
            this.saveFileDialog.DefaultExt = "png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 700);
            this.Controls.Add(this.thirdChannelLabel);
            this.Controls.Add(this.secondChannelLabel);
            this.Controls.Add(this.firstChannelLabel);
            this.Controls.Add(this.labSettingsGroupBox);
            this.Controls.Add(this.sourceImage);
            this.Controls.Add(this.secondChannelImage);
            this.Controls.Add(this.firstChanelImage);
            this.Controls.Add(this.thirdChannelImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.thirdChannelImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstChanelImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondChannelImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.labSettingsGroupBox.ResumeLayout(false);
            this.labSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox thirdChannelImage;
        private PictureBox firstChanelImage;
        private PictureBox secondChannelImage;
        private PictureBox sourceImage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadImageToolStripMenuItem;
        private ToolStripMenuItem saveOutputToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem separateChannelsToolStripMenuItem;
        private ToolStripMenuItem targetColorModelToolStripMenuItem;
        private ToolStripMenuItem yCbCrToolStripMenuItem;
        private ToolStripMenuItem hSVToolStripMenuItem;
        private ToolStripMenuItem labToolStripMenuItem;
        private GroupBox labSettingsGroupBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox illuminantComboBox;
        private Label label2;
        private Label label1;
        private ComboBox colorProfileComboBox;
        private Label firstChannelLabel;
        private Label secondChannelLabel;
        private Label thirdChannelLabel;
        private Label label10;
        private TextBox gammaInput;
        private TextBox whiteYInput;
        private TextBox blueYInput;
        private TextBox greenYInput;
        private TextBox whiteXInput;
        private TextBox blueXInput;
        private TextBox greenXInput;
        private TextBox redXInput;
        private TextBox redYInput;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}