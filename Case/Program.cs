using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 2");
            Console.WriteLine("Выполнил студент группы 24 ис Козырский Илья");
            Console.WriteLine("Введите номер месяца: ");
            string selection = Console.ReadLine();// строковая переменная
            switch (selection) // сравниваем выражение
            {
                case "1": // значение выражения
                    Console.WriteLine("Январь");
                    break;
                case "2": // значение выражения
                    Console.WriteLine("Февраль");
                    break;
                case "3": // значение выражения
                    Console.WriteLine("Март");
                    break;
                case "4": // значение выражения
                    Console.WriteLine("Апрель");
                    break;
                case "5": // значение выражения
                    Console.WriteLine("Май");
                    break;
                case "6": // значение выражения
                    Console.WriteLine("Июнь");
                    break;
                case "7": // значение выражения
                    Console.WriteLine("Июль");
                    break;
                case "8": // значение выражения
                    Console.WriteLine("Август");
                    break;
                case "9": // значение выражения
                    Console.WriteLine("Сентябрь");
                    break;
                case "10": // значение выражения
                    Console.WriteLine("Октябрь");
                    break;
                case "11": // значение выражения
                    Console.WriteLine("Ноябрь");
                    break;
                case "12": // значение выражения
                    Console.WriteLine("Декабрь");
                    break;
                default:// совпадений нет
                    Console.WriteLine("ошибка при вводе");
                    break;


            }
            Console.ReadKey();// конец программы

        }
    }
}
