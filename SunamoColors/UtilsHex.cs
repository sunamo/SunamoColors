// EN: Variable names have been checked and replaced with self-descriptive names
// CZ: Názvy proměnných byly zkontrolovány a nahrazeny samopopisnými názvy

namespace SunamoColors;

public class UtilsHex
{
    /// <summary>
    ///     converts an array of bytes to a string Hex representation
    ///     Prevedu pole bytu A1 na hexadecimalni retezec.
    /// </summary>
    public static string ToHex(List<byte> ba)
    {
        if (ba == null || ba.Count == 0) return "";
        const string HexFormat = "{0:X2}";
        var stringBuilder = new StringBuilder();
        foreach (var builder in ba) stringBuilder.Append( /*SHFormat.Format4*/string.Format(HexFormat, builder));
        return stringBuilder.ToString();
    }
    /// <summary>
    ///     converts from a string Hex representation to an array of bytes
    ///     Prevedu retezec v hexadeximalni formatu A1 na pole bytu. Pokud nebude hex format(naprikal nebude mit sudy pocet
    ///     znaku), VV
    /// </summary>
    public static List<byte> FromHex(string hexEncoded)
    {
        if (hexEncoded == null || hexEncoded.Length == 0) return null;
        try
        {
            hexEncoded = hexEncoded.TrimStart('#');
            var list = Convert.ToInt32(hexEncoded.Length / 2);
            var builder = new List<byte>(list);
            for (var i = 0; i <= list - 1; i++) builder.Add(Convert.ToByte(hexEncoded.Substring(i * 2, 2), 16));
            return builder;
        }
        catch (Exception ex)
        {
            throw new Exception(Translate.FromKey(XlfKeys.TheProvidedStringDoesNotAppearToBeHexEncoded) + ":" +
                                Environment.NewLine + hexEncoded + Environment.NewLine +
                                Exceptions.TextOfExceptions(ex));
            return null;
        }
    }
}