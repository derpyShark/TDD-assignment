using System.Linq;
using System.Numerics;

namespace Kata
{
    public static class StringSumKata
    {
        public static string AddStringNaturalNumbers(string num1, string num2)
        {
            if (num1 == null || num2 == null)
            {
                throw new ArgumentNullException("One of the provided values was null");
            }

            VerifyNumberFormat(num1);
            VerifyNumberFormat(num2);

            var bigInteger1 = BigInteger.Parse(num1);
            var bigInteger2 = BigInteger.Parse(num2);

            var sum = bigInteger1 + bigInteger2;
            return sum.ToString();
        }

        private static void VerifyNumberFormat(string num)
        {
            if (num == string.Empty || num[0] == '0' || !num.All(c => IsNumChar(c)))
            {
                throw new ArgumentException("Provided string is not a natural number");
            }
        }

        private static bool IsNumChar(char character)
        {
            var zeroChar = '0';
            var zeroCharInt = (int)zeroChar;
            var characterInt = (int)character;
            if (characterInt >= zeroCharInt && characterInt < zeroCharInt + 10)
            {
                return true;
            }
            return false;
        }
    }
}
