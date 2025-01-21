namespace Modul5
{
    internal class Program
    {
        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }


        static void SortArray(in int[] arr, out int[] ArrDesc, out int[] ArrAsc)
        {
            ArrDesc = SortArrayDesc(arr);
            ArrAsc = SortArrayAsc(arr);       
        }
        static int[] SortArrayDesc(int[] ArrDesc)
        {
            for (int i = 0; i < ArrDesc.Length; i++)
            {
                for (int j = i + 1; j < ArrDesc.Length; j++)
                {
                    if (ArrDesc[i] > ArrDesc[j])
                    {
                        int first = ArrDesc[i];
                        ArrDesc[i] = ArrDesc[j];
                        ArrDesc[j] = first;
                    }
                }
            }
            return ArrDesc;
        }
        static int[] SortArrayAsc(int[] ArrAsc)
        {
            for (int i = 0; i < ArrAsc.Length; i++)
            {
                for (int j = i + 1; j < ArrAsc.Length; j++)
                {
                    if (ArrAsc[i] < ArrAsc[j])
                    {
                        int first = ArrAsc[i];
                        ArrAsc[i] = ArrAsc[j];
                        ArrAsc[j] = first;
                    }
                }
            }
            return ArrAsc;
        }






        /*static void ShowArray(int[] numbers, bool IsSort = false)
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
        }*/


        static void GetName(ref string name)
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
        }

        static void ChangeAge(int age)
        {
            age++;
            Console.WriteLine(age);
        }




        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }





        static string ShowColor(string username, int userage)
        {
            //Console.WriteLine(username + ", " + userage + " лет.\nНапишите свой любимый цвет на английском языке с маленькой буквы:");
            //string color = Console.ReadLine();

            int other = userage += 3;

            switch (userage | other)
            {
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                case 3:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                case 4:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                case 5:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    break;
            }
            return username;
        }




        static void Echo(string saidword, int deep)
        {
            var modif = saidword;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
                Console.BackgroundColor = (ConsoleColor)deep;
                Console.ForegroundColor = ConsoleColor.Black;
                //ShowColor(modif, deep);
                Console.WriteLine("..." + modif);
            }

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }





        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            else
            {
                return x * Factorial(x - 1);
            }
        }


        private static int PowerUp(int N, byte pow)
        {            
            if (pow == 0)
            {
                return 1;
            }
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }






        static void Main(string[] args)            
        {

            Console.Write("Введите число: ");
            var N = int.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            var pow = byte.Parse(Console.ReadLine());

            Console.WriteLine(PowerUp(N, pow));





            //var value = 20;
            //Console.WriteLine(Factorial(value));




            /*Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);*/







            //int num = 10;
            //var array = GetArrayFromConsole(ref num);
            //Console.WriteLine(num);

            //ShowArray(array, true);

            /*var someName = "Евгения";
            Console.WriteLine(someName);
            GetName(ref someName);
            Console.WriteLine(someName);
            
            Console.Write("Введите возраст: ");
            var someAge = int.Parse(Console.ReadLine());
            ChangeAge(someAge);
            Console.WriteLine(someAge);*/

            //var arr = new int[] {1, 2, 3};
            //BigDataOperation(arr);

            //Console.WriteLine(arr[0]);


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
