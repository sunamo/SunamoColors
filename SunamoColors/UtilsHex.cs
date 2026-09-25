namespace SunamoColors;

public class UtilsHex
{
    public static string ToHex(List<byte> bytes)
    {
        if (bytes == null || bytes.Count == 0) return "";
        const string HexFormat = "{0:X2}";
        var stringBuilder = new StringBuilder();
        foreach (var byteValue in bytes) stringBuilder.Append(string.Format(HexFormat, byteValue));
        return stringBuilder.ToString();
    }

    public static List<byte> FromHex(string hexEncoded)
    {
        if (hexEncoded == null || hexEncoded.Length == 0) return new List<byte>();
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
        }
    }
}
