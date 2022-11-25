using System.Numerics;
using rgb_separation.model;

namespace rgb_separation;

internal class Rgb2LabSeparator: IRgbSeparator
{
    private Color lChannel; 
    private Color aChannel; 
    private Color bChannel;
    private LabSettings labSettings;

    public Rgb2LabSeparator(LabSettings labSettings)
    {
        lChannel = Color.Black;
        aChannel = Color.Black;
        bChannel = Color.Black;
        this.labSettings = labSettings;
    }

    public void separate(Color sourceColor)
    {
        var normalisedColor = new Vector3(sourceColor.R / 255f, sourceColor.G / 255f, sourceColor.B / 255f);
        var illuminantVar = getIlluminantVars();
        var y = 0.299f * normalisedColor.X + 0.587f * normalisedColor.Y + 0.114f * normalisedColor.Z;
        var red = new Vector3(
            labSettings.Profile.RedPrimary.X * y / labSettings.Profile.RedPrimary.Y,
            y,
            (1-labSettings.Profile.RedPrimary.X * y / labSettings.Profile.RedPrimary.Y - y) * 
            labSettings.Profile.RedPrimary.X * y / labSettings.Profile.RedPrimary.Y
        );
        var green = new Vector3(
            labSettings.Profile.GreenPrimary.X * y / labSettings.Profile.GreenPrimary.Y,
            y,
            (1-labSettings.Profile.GreenPrimary.X * y / labSettings.Profile.GreenPrimary.Y - y) * 
            labSettings.Profile.GreenPrimary.X * y / labSettings.Profile.GreenPrimary.Y
        );
        var blue = new Vector3(
            labSettings.Profile.BluePrimary.X * y / labSettings.Profile.BluePrimary.Y,
            y,
            (1-labSettings.Profile.BluePrimary.X * y / labSettings.Profile.BluePrimary.Y - y) * 
            labSettings.Profile.BluePrimary.X * y / labSettings.Profile.BluePrimary.Y
        );
        float finalX = normalisedColor.X * red.X + normalisedColor.Y * green.X + normalisedColor.Y * blue.X;
        float finalY = normalisedColor.X * red.Y + normalisedColor.Y * green.Y + normalisedColor.Y * blue.Y;
        float finalZ = normalisedColor.X * red.Z + normalisedColor.Y * green.Z + normalisedColor.Y * blue.Z;

        float cielabYY = cielab2CiexyzFunc(finalY / illuminantVar.Y);
        float l = 116 * cielabYY - 16;
        float a = 500 * (cielab2CiexyzFunc(finalX / illuminantVar.X) - cielabYY);
        float b = 200 * (cielabYY - cielab2CiexyzFunc(finalZ / illuminantVar.Z));
         
        lChannel = Color.FromArgb((int)(l), (int)(l), (int)(l));
        aChannel = Color.FromArgb((int)(a + 127), (int)(128 - a), 127);
        bChannel = Color.FromArgb((int)(b + 127), 127, (int)(128 - b));
    }

    private float cielab2CiexyzFunc(float t)
    {
        float delta = 6f / 29;
        if (t > Math.Pow(delta, 3))
            return (float)Math.Pow(t, 1 / 3.0);
        return (float)(t / 3 * Math.Pow(delta, 2) + 4f / 29);
    }
    
    private Vector3 getIlluminantVars()
    {
        return new Vector3(95.0489f, 100f, 108.84f);
    }

    public Color getFirstChannelColor()
    {
        return lChannel;
    }

    public Color getSecondChannelColor()
    {
        return aChannel;
    }

    public Color getThirdChannelColor()
    {
        return bChannel;
    }
}