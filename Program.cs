using System;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;

namespace OOP_Lab_02
{
    class Program
    {
        static void Task1()
        {
            // Task 1

            // a)
            bool bl = true;
            Console.WriteLine($"Bool:\t\t{bl}");

            byte bt = 12;
            Console.WriteLine($"Byte:\t\t{bt}");

            sbyte sbt = -10;
            Console.WriteLine($"sByte:\t\t{sbt}");

            char ch = 'V';
            Console.WriteLine($"Char:\t\t{ch}");

            decimal dcml = 7.921M;
            Console.WriteLine($"Decimal:\t{dcml}");

            double dbl = 5.33;
            Console.WriteLine($"Double:\t\t{dbl}");

            float flt = 10.22F;
            Console.WriteLine($"Float:\t\t{flt}");

            int nt = 5;
            Console.WriteLine($"Int:\t\t{nt}");

            uint unt = 10;
            Console.WriteLine($"uInt:\t\t{unt}");

            long lng = -101010;
            Console.WriteLine($"Long:\t\t{lng}");

            ulong ulng = 132013120;
            Console.WriteLine($"uLong:\t\t{ulng}");

            short shrt = -1;
            Console.WriteLine($"Short:\t\t{shrt}");

            ushort ushrt = 100;
            Console.WriteLine($"uShort:\t\t{ushrt}");

            // b)
            int inumber = 10;
            long lnumber = inumber;

            float fnumber = 4.5F;
            double dnumber = fnumber;

            short snumber = 15;
            lnumber = snumber;

            byte bnumber = 1;
            inumber = bnumber;
            //
            inumber = (int)fnumber;

            inumber = Convert.ToInt32(dnumber);

            string str = Convert.ToString(1100);

            // c)

            int number = 5;
            Object buffer = number;
            number = (int)buffer;

            float real = 5.0F;
            buffer = real;
            real = (float)number;

            // d)
            var variable = 12.3;
            variable += 5.7;

            // e)
            int? isitnull = null; // упрощенная форма
            Nullable<int> yesitis = null; // полная запись

            Console.Write($"\nРавны ли две Nullable-type переменные? {isitnull == yesitis}");

            // f)
            var some_variable = 5; // неявно типизированная локальная переменная
            //some_variable = "text";
        }
        static void Task2()
        {
            // a)
            string one = "one", two = "two", onemore = "one";
            Console.WriteLine($"Равна ли строка '{one}' строке '{two}'? {one == two}\n");
            Console.WriteLine($"А строка '{one}' строке '{onemore}'? {one == onemore}\n");

            // b)
            string first = "12.3", second = "te.xt", third = "45.6";
            Console.WriteLine($"first + second + third = '{first + second + third}'\n");

            string[] words = (first + second + third).Split(new char[] { '.' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            first = "New String-type variable takes new place in memory";
            first = first.Substring(4);
            Console.WriteLine($"\n{first}");

            second = " always";
            first = first.Insert(20, second);
            Console.WriteLine($"\n{first}");

            first = first.Replace("-type", "-class-type");
            Console.WriteLine($"\n{first}");

            double somenumber = 10.91523;
            string result = String.Format("{0:0}", somenumber);
            Console.WriteLine($"\n{result}");

            // c)
            string empty = ""; 

            string notempty = null;

            empty += "hello";
            Console.WriteLine($"\n{empty}");

            Console.WriteLine($"\nIs it null? {string.IsNullOrEmpty(notempty)}\n");

            // d)

            StringBuilder sb = new StringBuilder("DEEF", 50);
            sb.Append(new char[] { 'A', 'B', 'C' });
            sb.Remove(1, 1);
            Console.WriteLine(sb);
        }
        static void Task3()
        {
            // a)
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.Write('\n');
            }
            Console.Write('\n');

            // b)
            string string1 = "Hello", string2 = "Good Evening", string3 = "Good Morning";
            string[] strings = { string1, string2, string3 };
            Console.Write("Массив: ");
            foreach (string str in strings)
            {
                Console.Write("[" + str + "] ");
            }
            Console.Write('\n');
            Console.Write($"Размер массива: {strings.Length}");

            Console.Write("\nНа что вы хотите поменять ее значение? ");
            string replace;
            replace = Console.ReadLine();

            Console.Write("\nВведите индекс ячейки ");
            int index = Convert.ToInt32(Console.ReadLine());

            strings[index] = replace;
            Console.Write("\nОбновленный массив: ");
            foreach (string str in strings)
            {
                Console.Write("[" + str + "] ");
            }

            // c)

            int[][] step = new int[3][];
            step[0] = new int[2];
            step[1] = new int[3];
            step[2] = new int[4];
            Console.Write("\nВведите зубчатый массив: \n");
            for (var i = 0; i < step.Length; i++)
            {
                for (int j = 0; j < step[i].Length; j++)
                {
                    Console.WriteLine($"Введите {j}-й элемент {i}-ой строки ");
                    step[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив:");
            foreach (int[] x in step)
            {
                foreach(int b in x)
                {
                    Console.Write($"{b} ");
                }
                Console.WriteLine('\n');
            }

            // d)
            var array_var = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var string_var = "Неявно типизированная строка";
            foreach(var a in array_var)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine(string_var);
        }

        static void Task4()
        {
            // a)

            (int, string, char, string, ulong) human = (15, "Dexter", 'D', "Industries", 12401250132);

            // b)

            Console.WriteLine($"Name: {human.Item2}\nFactory: {human.Item4}\nId: {human.Item5}\n");

            // c)

            (int, string, char) CreateCortage(string name)
            {
                int length = name.Length;
                string str = $"My name is {name}";
                char ch = (char)(name[0]);
                return (length, str, ch);
            }
            string name = "Viktor";
            var (one, two, three) = CreateCortage(name);
            (int first, string second, char third) newTuple = CreateCortage(name);
            Console.WriteLine($"{one} {two} {three}\n");
            Console.WriteLine($"{newTuple.first} {newTuple.second} {newTuple.third}\n");

            // d)

            Console.WriteLine($"Does '(one, two, three)' equal to 'newTuple'? {(one, two, three) == newTuple}\n");
        }
        static void Main(string[] args)
        {
            static (int, int, int, char) Task5(int[] arr, string str)
            {
                Array.Sort(arr);
                int sum = 0;
                foreach(int element in arr)
                {
                    sum += element;
                }
                char simbol = str[0];
                return (arr[arr.Length - 1], arr[0], sum, simbol);
            }

            static void Task6First() {
                checked
                {
                    int number = Int32.MaxValue;
                    Console.WriteLine(number);
                }
            }
            
            static void Task6Second()
            {
                unchecked
                {
                    int number = Int32.MaxValue + 1;
                    Console.WriteLine(number);
                }
            }

            int answer;
            do
            {
                Console.WriteLine("\n-----------------------\n");
                Console.WriteLine("Choose task option\n");
                Console.WriteLine("1) Types");
                Console.WriteLine("2) Strings");
                Console.WriteLine("3) Arrays");
                Console.WriteLine("4) Tuples");
                Console.WriteLine("5) Local function in main");
                Console.WriteLine("6) Checked and unchecked");
                Console.WriteLine("9) Clear Console");
                Console.WriteLine("0) Exit");
                
                answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        int[] arr = { 5, 4, 1, 3, 2 };
                        string textstr = "some text";
                        var (one, two, three, four) = Task5(arr, textstr);
                        Console.WriteLine($"\n Max: {one}, Min: {two}, Sum: {three}, Simbol: '{four}'\n");
                        break;
                    case 6:
                        Console.WriteLine("Checked:");
                        Task6First();
                        Console.WriteLine("Unchecked:");
                        Task6Second();
                        break;
                    case 9:
                        Console.Clear();
                        break;
                    case 0:
                        answer = 0;
                        break;
                    default:
                        Console.WriteLine("Something went wrong, try again");
                        continue;
                }
                
            } while (answer != 0);
        }
    }
}
