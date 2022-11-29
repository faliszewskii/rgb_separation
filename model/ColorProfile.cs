using System.Numerics;

namespace rgb_separation.model
{
    internal enum PredefinedColorProfile
    {
        SRgb,
        AdobeRgb,
        AppleRgb,
        CieRgb,
        WideGamut,
    }

    internal class ColorProfile
    {
        public Vector2 RedPrimary { get; set; }
        public Vector2 BluePrimary { get; set; }
        public Vector2 GreenPrimary { get; set; }

        public ColorProfile(
            Vector2 redPrimary, 
            Vector2 greenPrimary,
            Vector2 bluePrimary
            )
        {
            RedPrimary = redPrimary;
            GreenPrimary = greenPrimary;
            BluePrimary = bluePrimary;
        }

        public ColorProfile()
        {
            RedPrimary = new Vector2(0,0);
            BluePrimary = new Vector2(0,0);
            GreenPrimary = new Vector2(0,0);
        }
    }

    internal class PredefinedColorProfileComboBoxModel
    {

        public string Name { get; }
        public PredefinedColorProfile PredefinedColorProfile { get; }

        public PredefinedColorProfileComboBoxModel(string name, PredefinedColorProfile predefinedColorProfile)
        {
            Name = name;
            PredefinedColorProfile = predefinedColorProfile;
        }

    }
}
