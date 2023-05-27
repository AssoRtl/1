using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int Search(string text)
        {
            char[] a = text.ToCharArray();
            int b = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 48 && a[i] <= 57)// числа
                {
                }
                else if (a[i] >= 65 && a[i] <= 90)// большик англ
                {
                }
                else if (a[i] >= 97 && a[i] <= 122)// маленькие англ
                {
                }
                else if (a[i] >= 1044 && a[i] <= 1103)//русские большие мальникие 
                {
                }
                else if (a[i] == 1025)//Ё
                {
                }
                else if (a[i] == 1105)//ё
                {
                }
                else
                {
                    b++;
                }
            }
            return b;
        }
    }
}
