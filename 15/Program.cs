using System;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static int Count(string str)
        {
            if (str != null || str == "")
            {
                string[] mass = str.Split(' '); 
                str = "";
                for (int i = 0; i < mass.Length; i++)
                {
                    str += mass[i];
                }
                return str.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}

//[TestMethod]
//public void TestMethod1()
//{
//    double[] arr = new double[5] { 16, 243, 34, 85, 56 };  //Тестовый массив

//    double res = Task12Console.Arr.MaxFromArr(arr); //Обращение к Task12Console

//    Assert.AreEqual(243, res); //Проверка самого большого числа о котором мы знаем (243) с результатом метода MaxFromArr(arr)
//}
