static class LogLine
{
    public static string Message(string logLine)
    {
        // var colon = logLine.IndexOf(":") + 1;
        // String cutString = logLine.Substring(colon, logLine.Length - colon);
        // var trimmed = cutString.Trim();
        // return trimmed;
        int semiIndex = logLine.IndexOf(":") + 1;
        string plainMessage = logLine.Substring(semiIndex, logLine.Length - semiIndex).Trim();
        return $"{plainMessage}";
    }

    public static string LogLevel(string logLine)
    {
        // var firstBracket = logLine.IndexOf("[") + 1;
        // var lastBracket = logLine.IndexOf("]");
        // return logLine.Substring(firstBracket, lastBracket - firstBracket).ToLower();
        int firstChar = logLine.IndexOf("[") + 1;
        int secondChar = logLine.IndexOf("]");
        string logText = logLine.Substring(firstChar, secondChar - firstChar);
        return logText.ToLower();
    }

    public static string Reformat(string logLine)
    {
        // var firstBracket = logLine.IndexOf("[");
        // var lastBracket = logLine.IndexOf("]");
        // var messType = logLine.Substring(firstBracket + 1, lastBracket - firstBracket -                             1).ToLower();
        // var message = logLine.Substring(lastBracket + 2, logLine.Length - lastBracket -                             2).Trim();
        // return $"{message} ({messType})";
        int firstChar = logLine.IndexOf("[") + 1;
        int secondChar = logLine.IndexOf("]");
        string logLevel = logLine.Substring(firstChar, secondChar - firstChar).ToLower();
        string logMessage = logLine.Substring(secondChar + 2, logLine.Length - secondChar -                                                                             2).Trim();
        string result = $"// => \"{logMessage} ({logLevel})\"";
        string result2 = $@"{logMessage} ({logLevel})";
        return result2;
    }
}
