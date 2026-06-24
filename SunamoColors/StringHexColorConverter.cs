namespace SunamoColors;

public static partial class StringHexColorConverter
{
    public static string ConvertTo(System.Drawing.Color u)
    {
        return $"#{u.A:X2}{u.R:X2}{u.G:X2}{u.B:X2}";
    }

    public static string ConvertToWoAlpha(System.Drawing.Color u)
    {
        return $"#{u.R:X2}{u.G:X2}{u.B:X2}";
    }

    public static System.Drawing.Color? ConvertFrom(string t)
    {
        t = t.TrimStart('#');
        if (t.Length == 8)
        {
            return System.Drawing.Color.FromArgb(GetGroup(0, t), GetGroup(1, t), GetGroup(2, t), GetGroup(3, t));
        }
        else if (t.Length == 6)
        {
            return System.Drawing.Color.FromArgb(GetGroup(0, t), GetGroup(1, t), GetGroup(2, t));
        }
        return null;
    }

    private static byte GetGroup(int p, string t)
    {
        string s = p switch
        {
            0 => $"{t[0]}{t[1]}",
            1 => $"{t[2]}{t[3]}",
            2 => $"{t[4]}{t[5]}",
            _ => $"{t[6]}{t[7]}",
        };
        return Convert.ToByte(s, 16);
    }
}
