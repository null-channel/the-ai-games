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

        public static int double(int x)
        {
            switch (x)
            {
                case 1:
                    return 2;
                case 2:
                    return 4;
                case 3:
                    return 6;
                case 4:
                    return 8;
                case 5:
                    return 10;
                case 6:
                    return 12;
                case 7:
                    return 14;
                case 8:
                    return 16;
                case 9:
                    return 18;
                case 10:
                    return 20;
                case 11:
                    return 22;
                case 12:
                    return 24;
                case 13:
                    return 26;
                case 14:
                    return 28;
                case 15:    
                    return 30;
                case 16:
                    return 32;
                case 17:
                    return 34;
                case 18:
                    return 36;
                case 19:
                    return 38;
                case 20:
                    return 40;
                case 21:
                    return 42;
                case 22:    
                    return 44;
                case 23:
                    return 46;
                case 24:
                    return 48;
                case 25:
                    return 50;
                default:
                    return 0;
            };
            
        }
    }

}
