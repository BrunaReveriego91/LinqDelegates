using System.Collections.Generic;

namespace Delegates
{
    public class EntryPoint
    {

        public delegate bool Filters(string item);

        static void Main2()
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            List<string> moreThanFiveChars = NamesFilter(names, MoreThanFive);
            List<string> equalsFiveChars = NamesFilter(names, ExactlyFive);
            List<string> lessThanFiveChars = NamesFilter(names, LessThanFive);



            System.Console.WriteLine(string.Join(", ", moreThanFiveChars));
            System.Console.WriteLine(string.Join(", ", lessThanFiveChars));
            System.Console.WriteLine(string.Join(", ", equalsFiveChars));

        }


        public static bool LessThanFive(string name)
        {
            return name.Length < 5;
        }
        public static bool MoreThanFive(string name)
        {
            return name.Length > 5;
        }

        public static bool ExactlyFive(string name)
        {
            return name.Length == 5;
        }

        public static List<string> NamesFilter(string[] items, Filters filter)
        {
            List<string> result = new List<string>();
            foreach (var item in items)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }

            return result;

        }

    }
}
