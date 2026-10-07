namespace SunamoWpf.AwesomeFont;

public static partial  class AwesomeFontControls
{
    public static double ReturnFontSizeForTextNextToAwesomeIconWithSize(double height)
    {
        var fontSize = height - 20 - 5;
        return fontSize;
    }
}