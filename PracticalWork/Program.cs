using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, y;//объявим переменныые
            Console.WriteLine("Вариант 2");
            Console.WriteLine("Выполнил студент группы 24 ис Козырский Илья");
            Console.WriteLine("Введите a= ");
            a = Convert.ToDouble(Console.ReadLine()); // Вводим значение a c клавиатуры 
            Console.WriteLine("Введите b= ");
            b = Convert.ToDouble(Console.ReadLine()); // Вводим значение b c клавиатуры 
            if (a > 0) //Условие при положительном или отрицательном значении a
            {
                y = a * b; // при условии если a>0, выполняется данное действие 
                Console.WriteLine($"y={y}"); // вывод на экран значение y              
            }
            else
            {
                y = a + b; // при условии если a<0, выполняется данное действие 
                Console.WriteLine($"y={y}"); // вывод на экран значение y

            }
            Console.ReadKey(); // конец программы

        }
    }
}
