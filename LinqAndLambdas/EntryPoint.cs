namespace LinqAndLambdas
{
    public static class EntryPoint
    {
        public static void LinqTests1()
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };


            var catsWithA = from cat in catNames
                            where cat.Contains("a")
                            where cat.Length < 5
                            select cat;

            System.Console.WriteLine(string.Join(", ", catsWithA));

            //example with linq

            var getNumbers = from number in numbers
                             where number > 5
                             where number < 10
                             orderby number ascending
                             select number;

            List<int> newNumbers = new List<int>();

            //example with foreach
            foreach (var number in numbers)
            {
                if (number < 5)
                {
                    newNumbers.Add(number);
                }

            }

            System.Console.WriteLine(string.Join(", ", newNumbers));
            System.Console.WriteLine(string.Join(", ", getNumbers));

        }
    }
}
