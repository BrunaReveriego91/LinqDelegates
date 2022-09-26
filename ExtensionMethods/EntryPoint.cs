namespace ExtensionMethods
{
    public static class EntryPoint
    {
        static void Main()
        {
            int[] array = { 5, 3, 1, 2, 3, 9, 100, 1 };
            //Sort(array);
            array.Sort();
            Console.WriteLine(string.Join(", ", array));
        }


    }
}
