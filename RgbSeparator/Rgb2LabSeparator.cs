using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Single;
using rgb_separation.model;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        var normalisedColor = DenseVector.OfArray( new[] { sourceColor.R / 255f, sourceColor.G / 255f, sourceColor.B / 255f });
        var illuminant = getIlluminant();

        float[] inputR = { labSettings.Profile.RedPrimary.X, labSettings.Profile.RedPrimary.Y, 1 - labSettings.Profile.RedPrimary.X - labSettings.Profile.RedPrimary.Y };
        float[] inputG = { labSettings.Profile.GreenPrimary.X, labSettings.Profile.GreenPrimary.Y, 1 - labSettings.Profile.GreenPrimary.X - labSettings.Profile.GreenPrimary.Y };
        float[] inputB = { labSettings.Profile.BluePrimary.X, labSettings.Profile.BluePrimary.Y, 1 - labSettings.Profile.BluePrimary.X - labSettings.Profile.BluePrimary.Y};       
        Matrix<float> inputMatrix = DenseMatrix.OfColumnArrays(inputR, inputG, inputB);
        Vector<float> srgb = DenseVector.OfArray(new[] { 0f, 0f, 0f });
        inputMatrix.Solve(illuminant, srgb);

        var rgb2Xyz = DenseMatrix.OfRowArrays(
            new[] {inputMatrix[0,0] * srgb[0], inputMatrix[0, 1] * srgb[1], inputMatrix[0, 2] * srgb[2] },
            new[] {inputMatrix[1,0] * srgb[0], inputMatrix[1, 1] * srgb[1], inputMatrix[1, 2] * srgb[2] },
            new[] {inputMatrix[2,0] * srgb[0], inputMatrix[2, 1] * srgb[1], inputMatrix[2, 2] * srgb[2] }
        );
        var final = rgb2Xyz.Multiply(normalisedColor);
        float gamma = labSettings.Gamma;
        var gamminized = DenseVector.OfArray(new[]
        {
            (float)Math.Pow(final[0] , 1/ gamma),
            (float)Math.Pow(final[1] , 1/ gamma),
            (float)Math.Pow(final[2] , 1/ gamma)
        });

        float cielabYy = ciexyz2CielabFunc(gamminized[1] / illuminant[1]);
        float l = 116 * cielabYy - 16;
        float a = 500 * (ciexyz2CielabFunc(gamminized[0] / illuminant[0]) - cielabYy);
        float b = 200 * (cielabYy - ciexyz2CielabFunc(gamminized[2] / illuminant[2]));

        l = Math.Max(0, Math.Min(l, 255));
        a = Math.Max(0, Math.Min(a, 255));
        b = Math.Max(0, Math.Min(b, 255));

        lChannel = Color.FromArgb((int)l, (int)l, (int)l);
        aChannel = Color.FromArgb((int)(a + 127), (int)(128 - a), 127);
        bChannel = Color.FromArgb((int)(b + 127), 127, (int)(128 - b));
    }

    private static float ciexyz2CielabFunc(float t)
    {
        const float delta = 6f / 29;
        if (t > Math.Pow(delta, 3))
            return (float)Math.Pow(t, 1 / 3.0);
        return (float)(t / 3 * Math.Pow(delta, 2) + 4f / 29);
    }
    
    private Vector<float> getIlluminant()
    {
        float x = labSettings.Illuminant.whitePoint.X;
        float y = labSettings.Illuminant.whitePoint.Y;
        return DenseVector.OfArray(new[] {x*(1f/y), 1f, (1-x-y)*1f/y});
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