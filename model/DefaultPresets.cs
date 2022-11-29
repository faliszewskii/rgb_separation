using System.Numerics;

namespace rgb_separation.model
{
    internal static class DefaultPresets
    {
        public static ColorProfile SRgbPreset = new ColorProfile(
              new Vector2(0.64f, 0.33f),
              new Vector2(0.3f, 0.6f),
              new Vector2(0.15f, 0.06f)
              );
        public static Illuminant d65Preset = new Illuminant(
                new Vector2(0.3127f, 0.3290f)
            );
        public static float gammaPreset = 2.2f;
    }
}
