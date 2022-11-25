using System.Numerics;

namespace rgb_separation.model
{
    enum PredefinedColorProfile
    {
        sRGB,
    }

    internal class ColorProfile
    {
        public Vector2 RedPrimary { get; set; }
        public Vector2 BluePrimary { get; set; }
        public Vector2 GreenPrimary { get; set; }

        public ColorProfile(
            Vector2 redPrimary, 
            Vector2 bluePrimary, 
            Vector2 greenPrimary
            )
        {
            RedPrimary = redPrimary;
            BluePrimary = bluePrimary;
            GreenPrimary = greenPrimary;
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
