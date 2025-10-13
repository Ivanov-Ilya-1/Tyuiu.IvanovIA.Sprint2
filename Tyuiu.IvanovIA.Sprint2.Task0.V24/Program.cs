using Tyuiu.IvanovIA.Sprint2.Task0.V24.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task0.V24
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine(" Тема : Операции Сравнения                                                *");
            Console.WriteLine(" Задание #0                                                               *");
            Console.WriteLine(" Вариант #24                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу из операций сравнений                                 *");
            Console.WriteLine(" (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) *");
            Console.WriteLine(" и арифметических выражений, которая вернет                               *");
            Console.WriteLine(" логическую последовательность(массив):                                   *");
            Console.WriteLine(" (True, True, False, False, True, True), при x = 135, y = 755             *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x = 135;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.WriteLine("X = " + x);
            Console.WriteLine("y = " + y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();


        }
    }
}