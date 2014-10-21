namespace QA.Framework.Core.Helpers
{
    using System;

    public static class RandomDataGenerator
    {
        private static string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        private static Random randomGenerator = new Random();
        private static DateTime startDate = new DateTime(1990, 1, 1);

        public static string GenerateRandomString(int minNumberOfChars, int maxNumberOfChars)
        {
            int stringLength = randomGenerator.Next(minNumberOfChars, maxNumberOfChars + 1);
            int lettersLength = letters.Length;

            char[] result = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                result[i] = letters[randomGenerator.Next(0, lettersLength)];
            }

            return new string(result);
        }

        public static DateTime GenerateRandomDate()
        {
            int randomDays = randomGenerator.Next(1, 365 * 50);

            return startDate.AddDays(randomDays);
        }

        public static DateTime GenerateRandomFutureDate()
        {
            int randomDays = randomGenerator.Next(1, 365 * 50);

            return DateTime.Now.AddDays(randomDays);
        }

        public static DateTime GenerateRandomPastDate()
        {
            int randomDays = randomGenerator.Next(1, 365 * 50) * (-1);

            return DateTime.Now.AddDays(randomDays);
        }

        public static int GenerateRandomNumber(int minValue, int maxValue)
        {
            return randomGenerator.Next(minValue, maxValue + 1);
        }
    }
}
