using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Single;
using rgb_separation.model;
using System.Runtime.InteropServices;

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
        var normalisedColor = DenseVector.OfArray( new float[] { sourceColor.R / 255f, sourceColor.G / 255f, sourceColor.B / 255f });
        var illuminantVar = getIlluminantVars();
        var illuminants = DenseVector.OfArray(new float[] { illuminantVar[0] / 100f , illuminantVar[1] / 100f , illuminantVar[2] / 100f });

        var inputR = new float[] { labSettings.Profile.RedPrimary.X, labSettings.Profile.RedPrimary.Y, 1 - labSettings.Profile.RedPrimary.X - labSettings.Profile.RedPrimary.Y };
        var inputG = new float[] { labSettings.Profile.GreenPrimary.X, labSettings.Profile.GreenPrimary.Y, 1 - labSettings.Profile.GreenPrimary.X - labSettings.Profile.GreenPrimary.Y };
        var inputB = new float[] { labSettings.Profile.BluePrimary.X, labSettings.Profile.BluePrimary.Y, 1 - labSettings.Profile.BluePrimary.X - labSettings.Profile.BluePrimary.Y};       
        Matrix<float> inputMatrix = DenseMatrix.OfColumnArrays(new float[][] { inputR, inputG, inputB });
        Vector<float> SRGB = DenseVector.OfArray(new float[] { 0f, 0f, 0f });
        inputMatrix.Solve(illuminants, SRGB);

        var RGB2XYZ = DenseMatrix.OfRowArrays(new float[][]{
            new[] {inputMatrix[0,0] * SRGB[0], inputMatrix[0, 1] * SRGB[1], inputMatrix[0, 2] * SRGB[2] },
            new[] {inputMatrix[1,0] * SRGB[0], inputMatrix[1, 1] * SRGB[1], inputMatrix[1, 2] * SRGB[2] },
            new[] {inputMatrix[2,0] * SRGB[0], inputMatrix[2, 1] * SRGB[1], inputMatrix[2, 2] * SRGB[2] }
        });
        var final = RGB2XYZ.Multiply(normalisedColor);
        float gamma = labSettings.Gamma;
        var gamminized = DenseVector.OfArray(new float[]
        {
            (float)Math.Pow(final[0] , 1/ gamma),
            (float)Math.Pow(final[1] , 1/ gamma),
            (float)Math.Pow(final[2] , 1/ gamma)
        });

        float cielabYY = ciexyz2CielabFunc(final[1] / illuminants[1]);
        float l = 116 * cielabYY - 16;
        float a = 500 * (ciexyz2CielabFunc(final[0] / illuminants[0]) - cielabYY);
        float b = 200 * (cielabYY - ciexyz2CielabFunc(final[2] / illuminants[2]));
         
        lChannel = Color.FromArgb((int)(l), (int)(l), (int)(l));
        aChannel = Color.FromArgb((int)(a + 127), (int)(128 - a), 127);
        bChannel = Color.FromArgb((int)(b + 127), 127, (int)(128 - b));
    }

    private float ciexyz2CielabFunc(float t)
    {
        float delta = 6f / 29;
        if (t > Math.Pow(delta, 3))
            return (float)Math.Pow(t, 1 / 3.0);
        return (float)(t / 3 * Math.Pow(delta, 2) + 4f / 29);
    }
    
    private Vector<float> getIlluminantVars()
    {
        return DenseVector.OfArray(new float[]  { 95.0489f, 100f, 108.84f});
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