namespace FindTheOddInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intfound = find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
        }

        public static int find_it(int[] seq)
        {
            var dict = new Dictionary<int, int>();

            foreach (int i in seq)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i] += 1;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            foreach (KeyValuePair<int, int> kvp in dict)
            {
                if (kvp.Value % 2 == 1)
                {
                    return kvp.Key;
                }
            }

            return -1;
        }

        public static int FindTheOddInt2(int[] intArray)
        {
            return intArray
                    .GroupBy(x => x)
                    .Single(g => g.Count() % 2 == 1)     
                    .Key;
            // Chaque groupe (IGrouping<TKey, TElement>)
            // a une Key, qui est la valeur des éléments regroupés.
        }

        public static int FindTheOddInt3(int[] seq)
        {
            // A COMPRENDRE XOR
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }

        public static int FindTheOddInt4(int[] intArray)
        {
            return intArray
                    .First(x => intArray.Count(s => s == x) % 2 == 1);
        }

        public static int FindTheOddInt5(int[] intArray)
        {
            return  intArray
                        .GroupBy(x => x)
                        .Where(x => (x.Count() % 2 == 1))
                        .Select(x => x.First())
                        .FirstOrDefault();
        }

        public static int FindTheOddInt6(int[] seq)
        {
            return seq.Aggregate(0, (a, b) => a ^ b);
        }
    }
}
