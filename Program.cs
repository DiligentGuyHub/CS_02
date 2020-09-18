using System;
using System.Collections.Specialized;

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

            Console.WriteLine($"\nIs it null? {string.IsNullOrEmpty(notempty)}");
        }
        static void Main(string[] args)
        {
            //Task1();
            Task2();





            Console.Write('\n');
        }
    }
}
