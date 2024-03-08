using System.Text;

namespace SchoolFoodStamps.Common
{
    /// <summary>
    /// This class is used to hash and reverse hash strings.
    /// </summary>
    public static class HashHelper
    {
        public static string ConvertIdToHashedString(string input)
        {
            StringBuilder result = new StringBuilder();

            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                int asciiValue = (int)input[i];
                if (asciiValue >= 97 && asciiValue <= 123)
                {
                    if (i % 2 == 1)
                    {
                        asciiValue += 2;
                    }
                }
                else if (asciiValue >= 48 && asciiValue <= 60)
                {
                    if (i % 2 == 0)
                    {
                        asciiValue ++;
                    }
                }

                char newChar = (char)asciiValue;
                result.Append(newChar);
            }

            return result.ToString().ToUpper();
        }

        public static string ReverseHashedStringToId(string hashedInput)
        {
            StringBuilder result = new StringBuilder();

            hashedInput = hashedInput.ToLower();

            for (int i = 0; i < hashedInput.Length; i++)
            {
                int asciiValue = (int)hashedInput[i];
                if (asciiValue >= 97 && asciiValue <= 123)
                {
                    if (i % 2 == 1)
                    {
                        asciiValue -= 2;
                    }
                }
                else if (asciiValue >= 48 && asciiValue <= 60)
                {
                    if (i % 2 == 0)
                    {
                        asciiValue --;
                    }
                }

                char newChar = (char)asciiValue;
                result.Append(newChar);
            }

            string reversedString = result.ToString().ToUpper();

            return reversedString;
        }
    }
}
