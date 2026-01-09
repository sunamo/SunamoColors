// variables names: ok
namespace SunamoColors;

/// <summary>
/// Provides utility methods for converting between byte arrays and hexadecimal string representations
/// </summary>
public class UtilsHex
{
    /// <summary>
    /// Converts an array of bytes to a hexadecimal string representation
    /// </summary>
    /// <param name="bytes">The byte array to convert</param>
    /// <returns>A hexadecimal string representation of the byte array, or empty string if the input is null or empty</returns>
    public static string ToHex(List<byte> bytes)
    {
        if (bytes == null || bytes.Count == 0) return "";
        const string HexFormat = "{0:X2}";
        var stringBuilder = new StringBuilder();
        foreach (var byteValue in bytes) stringBuilder.Append(string.Format(HexFormat, byteValue));
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Converts a hexadecimal string representation to an array of bytes
    /// </summary>
    /// <param name="hexEncoded">The hexadecimal string to convert (can start with #)</param>
    /// <returns>A list of bytes representing the hexadecimal string, or empty list if the input is null or empty</returns>
    /// <exception cref="Exception">Thrown when the provided string does not appear to be hex encoded</exception>
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