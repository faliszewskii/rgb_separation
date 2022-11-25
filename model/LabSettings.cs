namespace rgb_separation.model;

internal class LabSettings
{
    public ColorProfile Profile { get; set; }
    public Illuminant Illuminant { get; set; }
    public float Gamma { get; set; }

    public LabSettings()
    {
        Profile = new ColorProfile();
        Illuminant = new Illuminant();
        Gamma = 0;
    }
    public LabSettings(ColorProfile profile, Illuminant illuminant, float gamma)
    {
        Profile = profile;
        Illuminant = illuminant;
        Gamma = gamma;
    }
}