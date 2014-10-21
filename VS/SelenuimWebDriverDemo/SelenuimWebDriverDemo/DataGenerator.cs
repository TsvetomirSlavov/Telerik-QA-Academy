namespace Homework
{
    using System;
    using System.Collections;

    public static class DataGenerator
    {
        private static string letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        private static Random randomGenerator = new Random();

        public static string Letters
        {
            get
            {
                return letters;
            }

            private set { }
        }

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
    }
}
