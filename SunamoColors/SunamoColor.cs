namespace SunamoColors;

public class SunamoColor
{
    public SunamoColor()
    {
    }

    public SunamoColor(byte alpha, byte red, byte green, byte blue)
    {
        A = alpha;
        R = red;
        G = green;
        B = blue;
    }

    public byte A { get; set; }
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }

    public override string ToString()
    {
        throw new Exception("StringHexColorConverter has been moved and is only available in WPF, not WinForms");
    }
}
