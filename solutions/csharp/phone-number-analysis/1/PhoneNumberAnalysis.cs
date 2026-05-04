public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYorkNumber = int.Parse(phoneNumber.Split("-")[0]) == 212;
        bool isFake = int.Parse(phoneNumber.Split("-")[1]) == 555;
        string lastFourDigits = phoneNumber.Split("-")[2];
        return (isNewYorkNumber, isFake, lastFourDigits);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)             => phoneNumberInfo.IsFake;
}
