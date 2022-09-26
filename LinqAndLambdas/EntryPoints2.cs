namespace LinqAndLambdas
{
    public class EntryPoints2
    {
        public static void LinqTests2()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tod",180,70,Gender.Male),
                new Person("John",170,88,Gender.Male),
                new Person("Anna",150,48,Gender.Female),
                new Person("Kyle",164,77,Gender.Female),
                new Person("Anna",164,77,Gender.Female),
                new Person("Maria",160,55,Gender.Female),
                new Person("John",160,55,Gender.Female),
            };

            var fourCharPeople = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Name descending, p.Height ascending
                                 select p;

            foreach (var item in fourCharPeople)
            {
                System.Console.WriteLine($"Name: {item.Name},Height: {item.Height}");
            }

        }
    }
}
