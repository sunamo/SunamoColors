// variables names: ok
namespace SunamoColors;

/// <summary>
/// Represents a color with alpha, red, green, and blue components
/// </summary>
public class SunamoColor
{
    /// <summary>
    /// Initializes a new instance of the SunamoColor class with default values
    /// </summary>
    public SunamoColor()
    {
    }

    /// <summary>
    /// Initializes a new instance of the SunamoColor class with specified ARGB values
    /// </summary>
    /// <param name="alpha">The alpha channel (transparency) value</param>
    /// <param name="red">The red channel value</param>
    /// <param name="green">The green channel value</param>
    /// <param name="blue">The blue channel value</param>
    public SunamoColor(byte alpha, byte red, byte green, byte blue)
    {
        A = alpha;
        R = red;
        G = green;
        B = blue;
    }


    /// <summary>
    /// Gets or sets the alpha channel (transparency) value
    /// </summary>
    public byte A { get; set; }

    /// <summary>
    /// Gets or sets the red channel value
    /// </summary>
    public byte R { get; set; }

    /// <summary>
    /// Gets or sets the green channel value
    /// </summary>
    public byte G { get; set; }

    /// <summary>
    /// Gets or sets the blue channel value
    /// </summary>
    public byte B { get; set; }

    /// <summary>
    /// Returns a string representation of this color
    /// </summary>
    /// <returns>A string representation of the color</returns>
    /// <exception cref="Exception">Thrown because StringHexColorConverter has been moved and is only available in WPF, not WinForms</exception>
    public override string ToString()
    {
        // System.Windows.Media.Color = #00000000
        // System.Drawing.Color = Color [A=0, R=0, G=0, B=0]
        throw new Exception("StringHexColorConverter has been moved and is only available in WPF, not WinForms");
    }
}