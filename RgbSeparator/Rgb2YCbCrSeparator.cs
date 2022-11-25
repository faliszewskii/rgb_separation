using System.Numerics;

namespace rgb_separation;

internal class Rgb2YCbCrSeparator: IRgbSeparator
{
    private Color yChannel = Color.Black; 
    private Color cbChannel = Color.Black; 
    private Color crChannel = Color.Black; 
    public void separate(Color sourceColor)
    {
        var normalisedColor = new Vector3(sourceColor.R / 255f, sourceColor.G / 255f, sourceColor.B / 255f);
        float y = 0.299f * normalisedColor.X + 0.587f * normalisedColor.Y + 0.114f * normalisedColor.Z;
        float cb = (normalisedColor.Z - y) / 1.772f + 0.5f;
        float cr = (normalisedColor.X - y) / 1.402f + 0.5f;

        yChannel = Color.FromArgb((int)(y * 255), (int)(y * 255), (int)(y * 255));
        cbChannel = Color.FromArgb(127, (int)((1-cb) * 255), (int)(cb * 255));
        crChannel = Color.FromArgb((int)(cr * 255), (int)((1-cr) * 255), 127);
    }

    public Color getFirstChannelColor()
    {
        return yChannel;
    }

    public Color getSecondChannelColor()
    {
        return cbChannel;
    }

    public Color getThirdChannelColor()
    {
        return crChannel;
    }
}