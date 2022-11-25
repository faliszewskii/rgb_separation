using rgb_separation.model;
using static rgb_separation.model.DefaultPresets;

namespace rgb_separation
{
    internal class RgbSeparatorApp
    {
        public ColorModel ColorModel { get; set; }
        private LabSettings LabSettings { get; set; }

        public Bitmap SourceImage { get; set; }
        public Bitmap FirstChannel { get; set; }
        public Bitmap SecondChannel { get; set; }
        public Bitmap ThirdChannel { get; set; }

        private readonly Dictionary<ColorModel, IRgbSeparator> converters = new();

        public RgbSeparatorApp(Bitmap source)
        {
            SourceImage = source;
            FirstChannel = new Bitmap(source.Width, source.Height);
            SecondChannel = new Bitmap(source.Width, source.Height);
            ThirdChannel = new Bitmap(source.Width, source.Height);
            ColorModel = ColorModel.YCbCr;
            LabSettings = new LabSettings(SRgbPreset, d65Preset, gammaPreset);
            converters.Add(ColorModel.YCbCr , new Rgb2YCbCrSeparator());
            converters.Add(ColorModel.Hsv , new Rgb2HsvSeparator());
            converters.Add(ColorModel.Lab , new Rgb2LabSeparator(LabSettings));
        }

        public void separateChannels()
        {
            for(int j=0; j<SourceImage.Height; j++)
            {
                for(int i=0; i<SourceImage.Width; i++)
                {
                    var sourceColor = SourceImage.GetPixel(i, j);
                    converters[ColorModel].separate(sourceColor);
                    
                    FirstChannel.SetPixel(i, j, converters[ColorModel].getFirstChannelColor());
                    SecondChannel.SetPixel(i, j, converters[ColorModel].getSecondChannelColor());
                    ThirdChannel.SetPixel(i, j, converters[ColorModel].getThirdChannelColor());
                }
            }
        }
    }
}