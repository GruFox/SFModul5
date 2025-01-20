namespace Modul5
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int first = arr[i];
                        arr[i] = arr[j];
                        arr[j] = first;
                    }
                }
            }
            return arr;
        }

        static void ShowArray(int[] numbers, bool IsSort = false)
        {
            foreach (int WriteNumbers in numbers)
            {
                Console.Write(WriteNumbers + " ");
            }
            
            Console.WriteLine();

            if (IsSort)
            {
                foreach (int SortWriteNumbers in SortArray(numbers))
                {
                    Console.Write(SortWriteNumbers + " ");
                }
            }          
        }







        static string ShowColor(string username, int userage)
        {
            Console.WriteLine(username + ", " + userage + " лет.\nНапишите свой любимый цвет на английском языке с маленькой буквы:");
            string color = Console.ReadLine();

            switch(color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static void Main(string[] args)            
        {
            var array = GetArrayFromConsole(10);

            ShowArray(array, true);




            /*var (name, age) = ("Igor", 38);

            Console.WriteLine("Моё имя: " + name);
            Console.WriteLine("Мой возраст: " + age);

            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите Ваш возраст цифрами: ");
            age = int.Parse(Console.ReadLine());

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }*/









            /*(string Name, string[] Dishes) User;

            Console.Write("Введите Ваше имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

            Console.WriteLine("Введите 5 Ваших любимых блюд:");

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                User.Dishes[i] = Console.ReadLine();
            }

            Console.WriteLine("Вас зовут " + User.Name);
            Console.WriteLine("И Ваши любимы блюда:\n" + "\t" + User.Dishes[0] + "\n" + "\t" + User.Dishes[1] + "\n" + "\t" + User.Dishes[2] + "\n" + "\t" + User.Dishes[3] + "\n" + "\t" + User.Dishes[4]);*/



        }
    }
}
