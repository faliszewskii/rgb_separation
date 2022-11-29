using System.Numerics;

namespace rgb_separation.model
{
    internal static class DefaultPresets
    {
        public static readonly Dictionary<PredefinedColorProfile, ColorProfile> PredefinedColorProfiles = new()
        {
            {
                PredefinedColorProfile.SRgb, new ColorProfile(
                    new Vector2(0.64f, 0.33f),
                    new Vector2(0.3f, 0.6f),
                    new Vector2(0.15f, 0.06f)
                )
            },
            {
                PredefinedColorProfile.AdobeRgb, new ColorProfile(
                    new Vector2(0.64f, 0.33f),
                    new Vector2(0.21f, 0.71f),
                    new Vector2(0.15f, 0.06f)
                )
            },
            {
                PredefinedColorProfile.AppleRgb, new ColorProfile(
                    new Vector2(0.625f, 0.34f),
                    new Vector2(0.28f, 0.595f),
                    new Vector2(0.155f, 0.07f)
                )
            },
            {
                PredefinedColorProfile.CieRgb, new ColorProfile(
                    new Vector2(0.735f, 0.265f),
                    new Vector2(0.274f, 0.717f),
                    new Vector2(0.167f, 0.007f)
                )
            },
            {
                PredefinedColorProfile.WideGamut, new ColorProfile(
                    new Vector2(0.7347f, 0.2653f),
                    new Vector2(0.1152f, 0.8264f),
                    new Vector2(0.1566f, 0.0177f)
                )
            }
        };
        public static readonly Dictionary<PredefinedIlluminant, Illuminant> PredefinedIlluminants = new()
        {
            { PredefinedIlluminant.A, new Illuminant(new Vector2(0.44757f, 0.40744f))},
            { PredefinedIlluminant.B, new Illuminant(new Vector2(0.3484f, 0.3516f))},
            { PredefinedIlluminant.C, new Illuminant(new Vector2(0.31006f, 0.31615f))},
            { PredefinedIlluminant.D50, new Illuminant(new Vector2(0.34567f, 0.35850f))},
            { PredefinedIlluminant.D55, new Illuminant(new Vector2(0.33242f, 0.34743f))},
            { PredefinedIlluminant.D65, new Illuminant(new Vector2(0.3127f, 0.3290f))},
            { PredefinedIlluminant.D75, new Illuminant(new Vector2(0.29902f, 0.31485f))},
            { PredefinedIlluminant._9300K, new Illuminant(new Vector2(0.2848f, 0.2932f))},
            { PredefinedIlluminant.E, new Illuminant(new Vector2(0.33333f, 0.33333f))},
            { PredefinedIlluminant.F2, new Illuminant(new Vector2(0.37207f, 0.37512f))},
            { PredefinedIlluminant.F7, new Illuminant(new Vector2(0.31285f, 0.32918f))},
            { PredefinedIlluminant.F11, new Illuminant(new Vector2(0.38054f, 0.37691f))}
        };

        public const float GammaPreset = 2.2f;
    }
}
