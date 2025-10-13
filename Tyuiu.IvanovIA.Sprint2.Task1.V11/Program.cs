using Tyuiu.IvanovIA.Sprint2.Task1.V11.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task1.V11
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine(" Тема : Логические операции                                               *");
            Console.WriteLine(" Задание #1                                                               *");
            Console.WriteLine(" Вариант #11                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу из операций сравнений                                 *");
            Console.WriteLine(" (==, !=, <, >, <=, >=, последовательность можно чередовать,              *");
            Console.WriteLine(" но использовать один раз в выражении) и логических операций              *");
            Console.WriteLine(" (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),  *");
            Console.WriteLine(" а также арифметических выражений, которая вернет логическую              *");
            Console.WriteLine(" последовательность(массив): (False, False, True, False, True, False)     *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            


            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);


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