using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _11_17
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = new double[5] { 16, 243, 34, 85, 56 };  //Тестовый массив

            double res = Task12Console.Arr.MaxFromArr(arr); //Обращение к Task12Console

            Assert.AreEqual(243, res); //Проверка самого большого числа о котором мы знаем (243) с результатом метода MaxFromArr(arr)
        }
    }
}
