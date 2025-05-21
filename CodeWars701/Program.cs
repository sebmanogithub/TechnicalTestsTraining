using System.Text;

namespace CodeWars701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dd = Encode("felkjiz");
        }

        public static string Encode(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str.ToUpper())
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int position = c - 'A' + 1;
                    sb.Append(position);
                }
            }

            return sb.ToString();
        }
    }
}
