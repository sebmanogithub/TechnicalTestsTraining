namespace CodeWars801
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Welcome(["John", "Smith"], "Phoenix", "Arizona");
        }

        public static string Welcome(string[] names, string city, string state)
        {
            string strName = String.Join(" ", names);
            return $"Hello, {strName}! Welcome to {city}, {state}! ";
        }
    }
}
