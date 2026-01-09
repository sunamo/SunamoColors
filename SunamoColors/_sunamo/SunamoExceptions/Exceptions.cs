// variables names: ok
namespace SunamoColors._sunamo.SunamoExceptions;

/// <summary>
/// Provides exception handling utilities
/// © www.sunamo.cz. All Rights Reserved.
/// </summary>
internal sealed partial class Exceptions
{
    /// <summary>
    /// Converts exception information to a text format
    /// </summary>
    /// <param name="ex">The exception to convert</param>
    /// <param name="isIncludingInner">If true, includes all inner exceptions in the output</param>
    /// <returns>A string containing the exception messages, or empty string if ex is null</returns>
    internal static string TextOfExceptions(Exception ex, bool isIncludingInner = true)
    {
        if (ex == null) return string.Empty;
        StringBuilder stringBuilder = new();
        stringBuilder.Append("Exception:");
        stringBuilder.AppendLine(ex.Message);
        if (isIncludingInner)
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                stringBuilder.AppendLine(ex.Message);
            }
        var result = stringBuilder.ToString();
        return result;
    }

    /// <summary>
    /// StringBuilder for storing additional inner information
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoInnerStringBuilder = new();

    /// <summary>
    /// StringBuilder for storing additional information
    /// </summary>
    internal readonly static StringBuilder AdditionalInfoStringBuilder = new();
}