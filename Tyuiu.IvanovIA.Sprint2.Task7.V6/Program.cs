using Tyuiu.IvanovIA.Sprint2.Task7.V6.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task7.V6
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine(" Тема : Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine(" Задание #7                                                               *");
            Console.WriteLine(" Вариант #6                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу на C#, которая запрашивает исходные данные            *");
            Console.WriteLine(" (вещественные значения) и вычисляет, находится ли точка                  *");
            Console.WriteLine(" с координатами X,Y в заштрихованной области.                             *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;
            bool res;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            if (res == true)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }

                Console.ReadKey();


        }
    }
}