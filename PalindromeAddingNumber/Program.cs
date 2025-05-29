namespace PalindromeAddingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = FindStepsPalindrome(3523);
        }

        static int FindStepsPalindrome(long num)
        {
            if (IsPalindrome(num))
            {
                return 0;
            }

            int nbSteps = 0;
            while (!IsPalindrome(num))
            {
                string str = num.ToString();
                string reversedStr = new string(str.Reverse().ToArray());
                num += long.Parse(reversedStr);
                nbSteps++;
            }

            return nbSteps;
        }

        static bool IsPalindrome(long num)
        {
            string str = num.ToString();

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int palindromeChainLength(ulong n)
        {
            var reversed = ulong.Parse(string.Concat($"{n}".Reverse()));
            return reversed == n ? 0 : 1 + palindromeChainLength(n + reversed);
        }

    }
}
