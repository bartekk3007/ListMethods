namespace ListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list0 = new List<int>(8);
            for(int i = 100; i < 115; i++)
            {
                list0.Add(i);
            }
            List<int> list1 = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            list1.Add(11);
            list1.AddRange(list0);
            Print(list1);
            List<int> list2 = new List<int>(list1);
            Print(list2);
            List<int> list3 = [ 1, 2, 3 ];
            Print(list3);

            List<Winner> winnerList = new List<Winner>
            {
                new Winner("Argentina", new[] {1978, 1986, 2022}),
                new Winner("Brazil", new[] {1958, 1962, 1970, 1994, 2002}),
                new Winner("England", new[]{1970}),
                new Winner("France", new[]{1998, 2018}),
                new Winner("Germany", new[] {1954, 1974, 1990, 2014}),
                new Winner("Italy", new[]{1934, 1938, 1982, 2006}),
                new Winner("Spain", new[]{2010}),
                new Winner("Uruguay", new[]{1930, 1950}),
            };
            winnerList.Sort();
            Print(winnerList);

            List<string> words = new List<string>()
            {
                "abecadlo", "cegła", "donica"
            };
            int search = words.BinarySearch("balon");
            if(search < 0)
            {
                words.Insert(~search, "balon");
            }
            Print(words);
        }

        private static void Print<T>(IEnumerable<T> elems)
        {
            foreach (T elem in elems)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
