namespace TheAIGames{
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person { FirstName = "John", LastName = "Doe" };
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}!");
        }
        public static string getLastName(Person person)
        {
            return person.FirstName;
        }

        public static int sumVec1(int[] vec)
        {
            int res = 0;
            for (int i = 0; i < (vec.Length -1); i++)
            {
                res += vec[i];
            }
            return res;
        }

        public static int sumVec(int[] vec)
        {
            int res = 0;
            for (int i = 0; i < vec.Length; i++)
            {
                res += 1;
            }
            return res;
        }
    }

    



}
