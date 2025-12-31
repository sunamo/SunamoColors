namespace SunamoColors;

public class UtilsHex
{
    /// <summary>
    ///     converts an array of bytes to a string Hex representation
    ///     Prevedu pole bytu A1 na hexadecimalni retezec.
    /// </summary>
    public static string ToHex(List<byte> bytes)
    {
        if (bytes == null || bytes.Count == 0) return "";
        const string HexFormat = "{0:X2}";
        var stringBuilder = new StringBuilder();
        foreach (var byteValue in bytes) stringBuilder.Append( /*SHFormat.Format4*/string.Format(HexFormat, byteValue));
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
            var capacity = Convert.ToInt32(hexEncoded.Length / 2);
            var bytes = new List<byte>(capacity);
            for (var i = 0; i <= capacity - 1; i++) bytes.Add(Convert.ToByte(hexEncoded.Substring(i * 2, 2), 16));
            return bytes;
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