static class LogLine
{
    public static string Message(string logLine)
    {
        var colon = logLine.IndexOf(":") + 1;
        String cutString = logLine.Substring(colon, logLine.Length - colon);
        var trimmed = cutString.Trim();
        return trimmed;
    }

    public static string LogLevel(string logLine)
    {
        var firstBracket = logLine.IndexOf("[") + 1;
        var lastBracket = logLine.IndexOf("]");
        return logLine.Substring(firstBracket, lastBracket - firstBracket).ToLower();
    }

    public static string Reformat(string logLine)
    {
        var firstBracket = logLine.IndexOf("[");
        var lastBracket = logLine.IndexOf("]");
        var messType = logLine.Substring(firstBracket + 1, lastBracket - firstBracket -                             1).ToLower();
        var message = logLine.Substring(lastBracket + 2, logLine.Length - lastBracket -                             2).Trim();
        return $"{message} ({messType})";
    }
}
