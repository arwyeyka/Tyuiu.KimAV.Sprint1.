using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KimAV.Sprint1.Task7.V20.Lib;
namespace Tyuiu.KimAV.Sprint1.Task7.V20
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
            Console.WriteLine("* Задание 7                                                                                              *");
            Console.WriteLine("* Вариант 20                                                                                              *");
            Console.WriteLine("* Выполнил: Ким Артём Владимирович | ИИПБ-25-1                                                           *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.*");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                       *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("                     y - z ");
            Console.WriteLine("                    --------");
            Console.WriteLine("                     (y - x)  ");
            Console.WriteLine("f = (y - x)----------------------");
            Console.WriteLine("                            2");
            Console.WriteLine("                 1 + (y + x)");
            double x, y, z;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение z:");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                             *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine(ds.Calculate(x, y, z));
            Console.ReadKey();

        }
    }
}
