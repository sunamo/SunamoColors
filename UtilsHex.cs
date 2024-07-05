namespace SunamoColors;
internal class UtilsHex
{
    /// <summary>
    /// converts an array of bytes to a string Hex representation
    /// Prevedu pole bytu A1 na hexadecimalni retezec.
    /// </summary>
    public static string ToHex(List<byte> ba)
    {
        if (ba == null || ba.Count == 0)
        {
            return "";
        }

        const string HexFormat = "{0:X2}";
        StringBuilder sb = new StringBuilder();
        foreach (byte b in ba)
        {
            sb.Append(/*SHFormat.Format4*/ string.Format(HexFormat, b));
        }

        return sb.ToString();
    }

    /// <summary>
    /// converts from a string Hex representation to an array of bytes
    /// Prevedu retezec v hexadeximalni formatu A1 na pole bytu. Pokud nebude hex format(naprikal nebude mit sudy pocet znaku), VV
    /// </summary>
    public static List<byte> FromHex(string hexEncoded)
    {
        if (hexEncoded == null || hexEncoded.Length == 0)
        {
            return null;
        }

        try
        {
            hexEncoded = hexEncoded.TrimStart('#');
            int l = Convert.ToInt32(hexEncoded.Length / 2);
            List<byte> b = new List<byte>(l);

            for (int i = 0; i <= l - 1; i++)
            {
                b.Add(Convert.ToByte(hexEncoded.Substring(i * 2, 2), 16));
            }

            return b;
        }
        catch (Exception ex)
        {
            throw new Exception(sess.i18n(XlfKeys.TheProvidedStringDoesNotAppearToBeHexEncoded) + ":" + Environment.NewLine + hexEncoded + Environment.NewLine + Exceptions.TextOfExceptions(ex));
            return null;
        }
    }
}
