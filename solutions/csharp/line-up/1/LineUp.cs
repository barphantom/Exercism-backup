public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ending = "th";
        int twoLastNums = number % 100;
        int lastNum = number % 10;
        if (twoLastNums is < 11 or > 13)
        {
            ending = lastNum switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        }
        
        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
    }
}
