namespace SunamoColors;

/// <summary>
/// Represents the sunamo color type.
/// </summary>
public class SunamoColor
{
    /// <summary>
    /// Initializes a new instance of the sunamo color class.
    /// </summary>
    public SunamoColor()
    {
    }

    /// <summary>
    /// Initializes a new instance of the sunamo color class.
    /// </summary>
    /// <param name="alpha">The alpha.</param>
    /// <param name="red">The red.</param>
    /// <param name="green">The green.</param>
    /// <param name="blue">The blue.</param>
    public SunamoColor(byte alpha, byte red, byte green, byte blue)
    {
        A = alpha;
        R = red;
        G = green;
        B = blue;
    }

    /// <summary>
    /// Gets or sets the a.
    /// </summary>
    public byte A { get; set; }
    /// <summary>
    /// Gets or sets the r.
    /// </summary>
    public byte R { get; set; }
    /// <summary>
    /// Gets or sets the g.
    /// </summary>
    public byte G { get; set; }
    /// <summary>
    /// Gets or sets the b.
    /// </summary>
    public byte B { get; set; }

    /// <summary>
    /// To string.
    /// </summary>
    /// <returns>The to string result.</returns>
    public override string ToString()
    {
        throw new Exception("StringHexColorConverter has been moved and is only available in WPF, not WinForms");
    }
}
