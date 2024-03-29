﻿using rgb_separation.model;
using static rgb_separation.model.DefaultPresets;

namespace rgb_separation
{
    internal class RgbSeparatorApp
    {
        public ColorModel ColorModel { get; set; }
        public LabSettings LabSettings { get; set; }

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
            LabSettings = new LabSettings(
                PredefinedColorProfiles[PredefinedColorProfile.SRgb],
                PredefinedIlluminants[PredefinedIlluminant.D65],
                GammaPreset);
            converters.Add(ColorModel.YCbCr , new Rgb2YCbCrSeparator());
            converters.Add(ColorModel.Hsv , new Rgb2HsvSeparator());
            converters.Add(ColorModel.Lab , new Rgb2LabSeparator(LabSettings));
        }

        public void separateChannels()
        {
            
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                using (Graphics gfx = Graphics.FromImage(FirstChannel))
                    gfx.FillRectangle(brush, 0, 0, FirstChannel.Width, FirstChannel.Height );
                using (Graphics gfx = Graphics.FromImage(SecondChannel))
                    gfx.FillRectangle(brush, 0, 0, SecondChannel.Width, SecondChannel.Height);
                using (Graphics gfx = Graphics.FromImage(ThirdChannel))
                    gfx.FillRectangle(brush, 0, 0, ThirdChannel.Width, ThirdChannel.Height);
            }
            for (int j=0; j<SourceImage.Height; j++)
            {
                for(int i=0; i<SourceImage.Width; i++)
                {
                    var sourceColor = SourceImage.GetPixel(i, j);
                    var converter = converters[ColorModel];
                    converter.separate(sourceColor);

                    FirstChannel.SetPixel(i, j, converter.getFirstChannelColor());
                    SecondChannel.SetPixel(i, j, converter.getSecondChannelColor());
                    ThirdChannel.SetPixel(i, j, converter.getThirdChannelColor());
                }
            }
        }
    }
}