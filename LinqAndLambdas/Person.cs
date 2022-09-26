namespace LinqAndLambdas
{
    public class Person
    {
        public Person(string name, int height, int weight, Gender gender)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public Gender Gender { get; set; }


    }

    public enum Gender
    {
        Male,
        Female
    }
}