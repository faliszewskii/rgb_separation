using System.Globalization;
using System.Numerics;
using rgb_separation.model;

namespace rgb_separation
{

    public partial class Form1 : Form
    {
        private readonly RgbSeparatorApp rgbSeparatorApp;
        private string imageName = string.Empty;
        private readonly List<PredefinedColorProfileComboBoxModel> predefinedColorProfileComboBoxList = new()
        {
            new PredefinedColorProfileComboBoxModel("sRGB", PredefinedColorProfile.SRgb),
            new PredefinedColorProfileComboBoxModel("AdobeRGB", PredefinedColorProfile.AdobeRgb),
            new PredefinedColorProfileComboBoxModel("AppleRGB", PredefinedColorProfile.AppleRgb),
            new PredefinedColorProfileComboBoxModel("CIE RGB", PredefinedColorProfile.CieRgb),
            new PredefinedColorProfileComboBoxModel("Wide Gamut", PredefinedColorProfile.WideGamut),
        };

        private readonly List<PredefinedIlluminantComboBoxModel> predefinedIlluminantComboBoxList = new()
        {
            new PredefinedIlluminantComboBoxModel("A", PredefinedIlluminant.A),
            new PredefinedIlluminantComboBoxModel("B", PredefinedIlluminant.B),
            new PredefinedIlluminantComboBoxModel("C", PredefinedIlluminant.C),
            new PredefinedIlluminantComboBoxModel("D50", PredefinedIlluminant.D50),
            new PredefinedIlluminantComboBoxModel("D55", PredefinedIlluminant.D55),
            new PredefinedIlluminantComboBoxModel("D65", PredefinedIlluminant.D65),
            new PredefinedIlluminantComboBoxModel("D75", PredefinedIlluminant.D75),
            new PredefinedIlluminantComboBoxModel("9300K", PredefinedIlluminant._9300K),
            new PredefinedIlluminantComboBoxModel("E", PredefinedIlluminant.E),
            new PredefinedIlluminantComboBoxModel("F2", PredefinedIlluminant.F2),
            new PredefinedIlluminantComboBoxModel("F7", PredefinedIlluminant.F7),
            new PredefinedIlluminantComboBoxModel("F11", PredefinedIlluminant.F11)
        };
        public Form1()
        {
            InitializeComponent();
            colorProfileComboBox.DisplayMember = "Name";
            illuminantComboBox.DisplayMember = "Name";
            colorProfileComboBox.DataSource = predefinedColorProfileComboBoxList;
            illuminantComboBox.DataSource = predefinedIlluminantComboBoxList;
            illuminantComboBox.SelectedIndex = 5;
            rgbSeparatorApp = new RgbSeparatorApp(new Bitmap(sourceImage.Width, sourceImage.Height));
            sourceImage.Image = rgbSeparatorApp.SourceImage;
            firstChanelImage.Image = rgbSeparatorApp.FirstChannel;
            secondChannelImage.Image = rgbSeparatorApp.SecondChannel;
            thirdChannelImage.Image = rgbSeparatorApp.ThirdChannel;
            var srgbPreset = DefaultPresets.PredefinedColorProfiles[PredefinedColorProfile.SRgb];
            var d65Preset = DefaultPresets.PredefinedIlluminants[PredefinedIlluminant.D65];
            setColorProfilePresetText(srgbPreset);
            setIlluminantPresetText(d65Preset);
            gammaInput.Text = DefaultPresets.GammaPreset.ToString(CultureInfo.InvariantCulture);
        }

        private void setIlluminantPresetText(Illuminant preset)
        {
            whiteXInput.Text = preset.whitePoint.X.ToString(CultureInfo.InvariantCulture);
            whiteYInput.Text = preset.whitePoint.Y.ToString(CultureInfo.InvariantCulture);
        }

        private void setColorProfilePresetText(ColorProfile profile)
        {
            redXInput.Text = profile.RedPrimary.X.ToString(CultureInfo.InvariantCulture);
            redYInput.Text = profile.RedPrimary.Y.ToString(CultureInfo.InvariantCulture);
            greenXInput.Text = profile.GreenPrimary.X.ToString(CultureInfo.InvariantCulture);
            greenYInput.Text = profile.GreenPrimary.Y.ToString(CultureInfo.InvariantCulture);
            blueXInput.Text = profile.BluePrimary.X.ToString(CultureInfo.InvariantCulture);
            blueYInput.Text = profile.BluePrimary.Y.ToString(CultureInfo.InvariantCulture);
        }
        private void colorProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colorProfileComboBox.SelectedItem is not PredefinedColorProfileComboBoxModel item || rgbSeparatorApp == null) return;
            rgbSeparatorApp.LabSettings.Profile = DefaultPresets.PredefinedColorProfiles[item.PredefinedColorProfile];
            setColorProfilePresetText(rgbSeparatorApp.LabSettings.Profile);
        }

        private void illuminantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (illuminantComboBox.SelectedItem is not PredefinedIlluminantComboBoxModel item || rgbSeparatorApp == null) return;
            rgbSeparatorApp.LabSettings.Illuminant = DefaultPresets.PredefinedIlluminants[item.PredefinedIlluminant];
            setIlluminantPresetText(rgbSeparatorApp.LabSettings.Illuminant);
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = imageName + "_" + firstChannelLabel.Text;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            rgbSeparatorApp.FirstChannel.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            saveFileDialog.FileName = imageName + "_" + secondChannelLabel.Text;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            rgbSeparatorApp.SecondChannel.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            saveFileDialog.FileName = imageName + "_" + thirdChannelLabel.Text;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            rgbSeparatorApp.ThirdChannel.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            imageName = openFileDialog.SafeFileName.Split(".")[0];
            var image = Image.FromFile(openFileDialog.FileName);
            
            if ((double)image.Height / image.Width > (double)sourceImage.Height / sourceImage.Width)
            {
                double scale = (double)sourceImage.Height / image.Height;
                rgbSeparatorApp.SourceImage = new Bitmap(image, (int)(image.Width * scale), sourceImage.Height);    
            }else
            {
                double scale = (double)sourceImage.Width / image.Width;
                rgbSeparatorApp.SourceImage = new Bitmap(image,sourceImage.Width, (int)(image.Height * scale));    
            }
            sourceImage.Image = rgbSeparatorApp.SourceImage;

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
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(redXInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.RedPrimary;
            rgbSeparatorApp.LabSettings.Profile.RedPrimary = currentVector with { X = parsedValue };
        }

        private void redYInput_TextChanged(object sender, EventArgs e)
        {
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(redYInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.RedPrimary;
            rgbSeparatorApp.LabSettings.Profile.RedPrimary = currentVector with { Y = parsedValue };
        }

        private void greenXInput_TextChanged(object sender, EventArgs e)
        {
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(greenXInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.GreenPrimary;
            rgbSeparatorApp.LabSettings.Profile.GreenPrimary = currentVector with { X = parsedValue };
        }

        private void greenYInput_TextChanged(object sender, EventArgs e)
        {
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(greenYInput.Text,NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.GreenPrimary;
            rgbSeparatorApp.LabSettings.Profile.GreenPrimary = currentVector with { Y = parsedValue };
        }

        private void blueXInput_TextChanged(object sender, EventArgs e)
        {
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(blueXInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.BluePrimary;
            rgbSeparatorApp.LabSettings.Profile.BluePrimary = currentVector with { X = parsedValue };
        }

        private void blueYInput_TextChanged(object sender, EventArgs e)
        {
            colorProfileComboBox.Text = "Custom";
            if (!float.TryParse(blueYInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Profile.BluePrimary;
            rgbSeparatorApp.LabSettings.Profile.BluePrimary = currentVector with { Y = parsedValue };
        }

        private void whiteXInput_TextChanged(object sender, EventArgs e)
        {
            illuminantComboBox.Text = "Custom";
            if (!float.TryParse(whiteXInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Illuminant.whitePoint;
            rgbSeparatorApp.LabSettings.Illuminant.whitePoint = currentVector with { X = parsedValue };
        }

        private void whiteYInput_TextChanged(object sender, EventArgs e)
        {
            illuminantComboBox.Text = "Custom";
            if (!float.TryParse(whiteYInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            var currentVector = rgbSeparatorApp.LabSettings.Illuminant.whitePoint;
            rgbSeparatorApp.LabSettings.Illuminant.whitePoint = currentVector with { Y = parsedValue };
        }

        private void gammaInput_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(gammaInput.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float parsedValue)) return;
            rgbSeparatorApp.LabSettings.Gamma = parsedValue;
        }
    }
}