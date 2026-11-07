using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint1.Task4.V13.Lib;
namespace Tyuiu.KimAV.Sprint1.Task4.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №0 | Выполнил: Ким А.В. | ИИПБ-25-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт # 1                                                                                             *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                                            *");
            Console.WriteLine("* Задание 4                                                                                              *");
            Console.WriteLine("* Вариант 13                                                                                              *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПБ-25-1                                                           *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");
            int x, y;
            Console.WriteLine("Введение значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введение значение y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("1 / (x ^ 2 + y ^ 2) = " + ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
