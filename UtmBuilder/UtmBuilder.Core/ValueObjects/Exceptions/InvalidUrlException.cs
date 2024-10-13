using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions;

public partial class InvalidUrlException : Exception
{
    private const string UrlRegexPattern = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
    private const string DefaultErrorMessage = "Invalid URL";

    public InvalidUrlException(string message = DefaultErrorMessage) : base(message)
    {
    }

    public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
    {
        if (string.IsNullOrEmpty(address)) throw new InvalidUrlException(message);
        if (!MyRegex().IsMatch(address)) throw new InvalidUrlException();
    }

    [GeneratedRegex(UrlRegexPattern)]
    private static partial Regex MyRegex();
}