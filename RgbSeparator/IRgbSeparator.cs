namespace rgb_separation;

public interface IRgbSeparator
{
    public void separate(Color sourceColor);
    public Color getFirstChannelColor();
    public Color getSecondChannelColor();
    public Color getThirdChannelColor();
}