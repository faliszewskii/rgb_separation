using rgb_separation.model;

namespace rgb_separation
{

    public partial class Form1 : Form
    {
        private readonly RgbSeparatorApp rgbSeparatorApp;
        public Form1()
        {
            InitializeComponent();
            colorProfileComboBox.DataSource = predefinedColorProfileComboBoxList;
            illuminantComboBox.DataSource = predefinedIlluminantComboBoxList;
            rgbSeparatorApp = new RgbSeparatorApp(new Bitmap(sourceImage.Width, sourceImage.Height));
            sourceImage.Image = rgbSeparatorApp.SourceImage;
            firstChanelImage.Image = rgbSeparatorApp.FirstChannel;
            secondChannelImage.Image = rgbSeparatorApp.SecondChannel;
            thirdChannelImage.Image = rgbSeparatorApp.ThirdChannel;
        }


        private readonly List<PredefinedColorProfileComboBoxModel> predefinedColorProfileComboBoxList = new()
        {
            new PredefinedColorProfileComboBoxModel("sRGB", PredefinedColorProfile.sRGB)
        };

        private readonly List<PredefinedIlluminantComboBoxModel> predefinedIlluminantComboBoxList = new()
        {
            new PredefinedIlluminantComboBoxModel("D65", PredefinedIlluminant.D65)
        };

        private void colorProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void illuminantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                rgbSeparatorApp.SourceImage = new Bitmap(image, rgbSeparatorApp.SourceImage.Width, rgbSeparatorApp.SourceImage.Height);
                sourceImage.Image = rgbSeparatorApp.SourceImage;
            }

        }

        private void toGrayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void separateChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rgbSeparatorApp.separateChannels();
            firstChanelImage.Refresh();
            secondChannelImage.Refresh();
            thirdChannelImage.Refresh();
        }

        private void yCbCrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rgbSeparatorApp.ColorModel = ColorModel.YCbCr;
            
            labToolStripMenuItem.Checked = false;
            hSVToolStripMenuItem.Checked = false;
            labSettingsGroupBox.Enabled = false;
            firstChannelLabel.Text = "Y";
            secondChannelLabel.Text = "Cb";
            thirdChannelLabel.Text = "Cr";
        }

        private void hSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rgbSeparatorApp.ColorModel = ColorModel.Hsv;
            
            yCbCrToolStripMenuItem.Checked = false;
            labToolStripMenuItem.Checked = false;
            labSettingsGroupBox.Enabled = false;
            firstChannelLabel.Text = "H";
            secondChannelLabel.Text = "S";
            thirdChannelLabel.Text = "V";
        }

        private void labToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rgbSeparatorApp.ColorModel = ColorModel.Lab;
            
            hSVToolStripMenuItem.Checked = false;
            yCbCrToolStripMenuItem.Checked = false;
            labSettingsGroupBox.Enabled = true;
            firstChannelLabel.Text = "L";
            secondChannelLabel.Text = "a";
            thirdChannelLabel.Text = "b";
        }

        private void redXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void redYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void greenXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void greenYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void blueXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void blueYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void whiteXInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void whiteYInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void gammaInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}