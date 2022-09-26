using System.Collections.Generic;

namespace Delegates
{
    public class EntryPoint2
    {

        public delegate bool Filters(string item);

        static void Main()
        {
            string[] names = { "Alice", "John", "Bobby", "Kyle", "Scott", "Tod", "Sharon", "Armin", "George" };

            List<string> moreThanFiveChars = NamesFilter(names, item => item.Length > 5);
            List<string> equalsFiveChars = NamesFilter(names, item => item.Length == 5);
            List<string> lessThanFiveChars = NamesFilter(names, item => item.Length < 5);




            System.Console.WriteLine("All names: " + string.Join(", ", names));
            System.Console.WriteLine(new string('-', 40));
            System.Console.WriteLine("Names more than five chars: " + string.Join(", ", moreThanFiveChars));
            System.Console.WriteLine("Names less than five chars: " + string.Join(", ", lessThanFiveChars));
            System.Console.WriteLine("Names equals five chars: " + string.Join(", ", equalsFiveChars));
            System.Console.WriteLine(new string('-', 40));
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
