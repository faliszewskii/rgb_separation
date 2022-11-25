using System.Numerics;

namespace rgb_separation;

internal class Rgb2HsvSeparator: IRgbSeparator
{
    private Color hChannel = Color.Black; 
    private Color sChannel = Color.Black; 
    private Color vChannel = Color.Black; 
    public void separate(Color sourceColor)
    {
        var normalisedColor = new Vector3(sourceColor.R / 255f, sourceColor.G / 255f, sourceColor.B / 255f);
        float rgbMax = Math.Max(normalisedColor.X, Math.Max(normalisedColor.Y, normalisedColor.Z));
        float rgbMin = Math.Min(normalisedColor.X, Math.Min(normalisedColor.Y, normalisedColor.Z));
        float chroma = rgbMax - rgbMin;

        float h = 0;
        if (chroma == 0)
            h = 0;
        else if (normalisedColor.X >= normalisedColor.Y && normalisedColor.X >= normalisedColor.Z)
            h = 60 * (normalisedColor.Y - normalisedColor.Z) / chroma;
        else if (normalisedColor.Y >= normalisedColor.X && normalisedColor.Y >= normalisedColor.Z)
            h = 60 * ( 2 + (normalisedColor.Z - normalisedColor.X) / chroma);
        else if (normalisedColor.Z >= normalisedColor.X && normalisedColor.Z >= normalisedColor.Y)
            h = 60 * ( 4 + (normalisedColor.X - normalisedColor.Y) / chroma);
        h = Math.Max(0, Math.Min(h, 360));
        
        float s = rgbMax!= 0 ? chroma / rgbMax: 0;
        float v = rgbMax;

         
        hChannel = Color.FromArgb((int)(h / 360 * 255), (int)(h / 360 * 255), (int)(h / 360 * 255));
        sChannel = Color.FromArgb((int)(s * 255), (int)(s * 255), (int)(s * 255));
        vChannel = Color.FromArgb((int)(v * 255), (int)(v * 255), (int)(v * 255));
    }

    public Color getFirstChannelColor()
    {
        return hChannel;
    }

    public Color getSecondChannelColor()
    {
        return sChannel;
    }

    public Color getThirdChannelColor()
    {
        return vChannel;
    }
}