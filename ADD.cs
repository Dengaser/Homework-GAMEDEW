using Microsoft.Win32;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз3
{
    internal class ADD
    {
        static void Main(string[] args)
        {
            one();
            two();
            quatro();
            fivus();
            six();
            seven();
            Eight();
            nine();
            ten();
            Odinadzat();
        }
        static void one()
        {
            Console.WriteLine("1 lvl");
            Console.WriteLine("Введи число которое пройдёт через модуль");
            Console.WriteLine(Abs(InputInt(Console.ReadLine())));



        }
        static int Abs(int x)
        {
            if (x >= 0)
            {
                return x;

            }
            else { return x * (-1);

            }
        }
        static int PrintWithInput()
        {
            Console.WriteLine("Введите желаемые цифры");
            return int.Parse(Console.ReadLine());
        }
        static int InputIntint(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        static int InputInt(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }
        static char InputChar(string input)
        {
            if (char.TryParse(input, out char ch))
            {
                return ch;
            }
            else
            {
                return '\0';
            }
        }
        static int Max3(int a, int b, int c)
        {
            if (a >= b)
            {
                if (a >= c)
                {
                    return a;
                }

            }
            if (b >= c)
            {
                if (b >= a)
                {
                    return b;
                }
            }
            if (c >= a)
            {
                if (c >= b)
                {
                    return c;
                }
            }
            return 0;
        }
        //задание 2

        static void two()
        {
            Console.WriteLine("     2 LVL");
            Console.WriteLine("Введи 3 числа чтобы найти максимальное из них");
            int a = InputInt(Console.ReadLine());
            int b = InputInt(Console.ReadLine());
            int c = InputInt(Console.ReadLine());
            Console.WriteLine(Max3(a, b, c));
            Console.WriteLine("LVL 3");//задание 3
            Console.WriteLine("Введи символ и сколько раз его повторить");
            PrintLine(Console.ReadLine(), InputInt(Console.ReadLine()));
        }

        static void PrintLine(string symbol, int count)
        {
            Console.WriteLine("LVL 3");
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }

        }
        //задание 4
        static void quatro()
        {
            Console.WriteLine();
            Console.WriteLine("LVL 4");
            Console.WriteLine("Что ты хочешь, чтобы повторилось, потом сколько раз");
            Console.WriteLine(Repeat(Console.ReadLine(), InputInt(Console.ReadLine())));

        }
        static string Repeat(string text, int times)
        {
            string[] s = new string[(int)times];
            ;
            for (int i = 0; i < times; i++)
            {
                s[i] = text;
            }
            var z = string.Join("", s);
            return z;
        }
        //задание 5
        static bool TryIndexOf(string s, char ch, out int index)
        {
            index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch)
                {
                    index = s[i];
                    return true;
                }


            }
            return false;
        }
        static void fivus()
        {
            Console.WriteLine("LVL 5");
            Console.WriteLine("введите строку, чтобы проверить есть ли в ней символ");
            Console.WriteLine(TryIndexOf(Console.ReadLine(), InputChar(Console.ReadLine()), out int index));
        }
        //static int Clamp(ref int value, int min=19, int max=30)
        //{
        //    Console.WriteLine("Введите число в пределе 19-30");
        //    //value= int.Parse(Console.ReadLine());
        //    if (value < min)
        //    {
        //        return min;
        //    }
        //    if (value > max)
        //    {
        //        return max;
        //    }
        //    return value;

        //}
        static void Clamp(ref int value, int min, int max)
        {
            if (value < min)
                value = min;
            else if (value > max)
                value = max;
        }
        static void six()
        {
            Console.WriteLine("LVL 6");
            Console.WriteLine("Введите число в пределе 19-30");
            int n = InputIntint(Console.ReadLine());
            Clamp(ref n, 19, 30);
            Console.WriteLine(n);
        }
        static void seven()
        {
            Console.WriteLine("Переверну что напишешь");
            Console.WriteLine(ReverseRec(Console.ReadLine()));

        }
        static string ReverseRec(string s)
        {
            return ReverseHelper(s, 0);
        }

        static string ReverseHelper(string s, int index)
        {
            if (index >= s.Length)
                return "";

            return ReverseHelper(s, index + 1) + s[index];
        }
        static void Eight()

        {
            Console.WriteLine("Введите число");
            Console.WriteLine(SumDigitsRec((int)Abs(InputInt(Console.ReadLine()))));
        }
        static int SumDigitsRec(int n)
        {
            if (n <= 9)
            { return n; }
            else
            { return (n % 10) + SumDigitsRec(n / 10); }

        }
        static void nine()
        {   
            Console.WriteLine("Тест на треугольник");
            Console.WriteLine(IsTriangle(InputIntint(Console.ReadLine()), InputIntint(Console.ReadLine()), InputIntint(Console.ReadLine())));
    
        }
        static bool IsTriangle(in int a, in int b, in int c)
        {
            if (a+b>c)
            {
                if (a+c>b)
                { 
                    if (b + c > a)
                    {
                        return true;
                    }
                }
            }
                
             return false;
        }
        
        static void ten()
        {
            Console.WriteLine("LVL 10");
            Console.WriteLine("простой метод");
            Console.WriteLine("Введи число, а потом степень в которую хочешь возвести число");
            int a = InputInt(Console.ReadLine());
            int n = InputInt(Console.ReadLine());
            Console.WriteLine(PowRec(a, n));
            Console.WriteLine($"Количество хотов {n}");
            Console.WriteLine("------------Умный метод------------");
            Console.WriteLine("Введи число, а потом степень в которую хочешь возвести число");
            int a1 = InputInt(Console.ReadLine());
            int n1 = InputInt(Console.ReadLine());
            Console.WriteLine(PowFast(a1, n1));
            if (n%2==0)
            {
                Console.WriteLine($"Количество ходов {n1 / 2 + 1}");
                if (Math.Log(n,2) + 1 == n) { Console.WriteLine("В этом случае они одинаково хороши"); }
                if (Math.Log(n, 2)+1 > n) { Console.WriteLine($"Обычная лучше на {(Math.Log(n, 2) + 1) - n}"); }
                if (Math.Log(n, 2) + 1 < n) { Console.WriteLine($"Умная лучше на {n - (Math.Log(n, 2) + 1)}"); }
            }
            else
            {
                Console.WriteLine($"Количество ходов {n1 / 2 + 2}");
                if (Math.Log(n, 2) + 2 == n) { Console.WriteLine("В этом случае они одинаково хороши"); }
                if (Math.Log(n, 2) + 2 > n) { Console.WriteLine($"Обычная лучше на {(Math.Log(n, 2) + 2) - n}"); }
                if (Math.Log(n, 2) + 2 < n) { Console.WriteLine($"Умная лучше на {n - (Math.Log(n, 2) + 2)}"); }

            }
            
        }
        static int PowRec(int a, int n)
        {
            if (n==1) { return a; }
            if (n == 0) {  return 1; }
            if (a == 1) { return 1; }
            if (a ==0) { return 0; }
            
            int c = 1;
            if (c==n)
            { return c; }
            n--;
            
            return PowRec(a, n) * a ;
        }
        static int PowFast(int a, int n )
        {
            if (n == 1) { return a; }
            if (n == 0) { return 1; }
            if (a == 1) { return 1; }
            if (a == 0) { return 0; }
            
            if (n % 2 == 0)
            {
                int c = 1;
                if (c == n / 2)
                { return c * c; }
                
                return PowFast(a, n-1) * a;
            }
            else
            {
                n --;
                return PowFast(a,n-1) * a*a;
            }
        }
        static string bol0( )
        {
            string s= Console.ReadLine();
            if (s.Length==0)
            {
                s = "Ты ничего не написал";
                return s;
            }
            else
                return s;
        }
        static void Odinadzat()
        {
            Console.WriteLine("Введи строку, чтобы я мог сжать повторяющиеся символы");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CompressRuns(bol0()));
            Console.ResetColor();
            Console.WriteLine("^^^^^^^Вот результат^^^^^^^");
        }
        static string CompressRuns(string s)
        {
            
            
            string sNew="";
            sNew =sNew+ s[0];
            
            for (int i = 0;i< s.Length-1;i++)
            {
                if (s[i] != s[i+1])
                {
                    sNew = sNew + s[i + 1];
                    
                }

            }
            return sNew;
        }
    }
    
}
