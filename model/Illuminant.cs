using System.Numerics;

namespace rgb_separation.model
{
    internal enum PredefinedIlluminant
    {
        A,
        B,
        C,
        D50,
        D55,
        D65,
        D75,
        _9300K,
        E,
        F2,
        F7,
        F11
    }
    internal class Illuminant
    {
        public Vector2 whitePoint;

        public Illuminant(
            Vector2 whitePoint
            )
        {
            this.whitePoint = whitePoint;
        }

        public Illuminant()
        {
            whitePoint = new Vector2(0, 0);
        }
    }
    internal class PredefinedIlluminantComboBoxModel
    {
        public string Name { get; }
        public PredefinedIlluminant PredefinedIlluminant { get; }

        public PredefinedIlluminantComboBoxModel(string name, PredefinedIlluminant predefinedIlluminant)
        {
            Name = name;
            PredefinedIlluminant = predefinedIlluminant;
        }
    }
}
