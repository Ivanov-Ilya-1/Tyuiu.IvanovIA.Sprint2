using Tyuiu.IvanovIA.Sprint2.Task2.V2.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task2.V2
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine(" Тема : Оператор if - полная и короткая форма записи                      *");
            Console.WriteLine(" Задание #2                                                               *");
            Console.WriteLine(" Вариант #2                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу на, которая запрашивает целые значения с клавиатуры   *");
            Console.WriteLine(" и вычисляет находится ли точка с координатами X,Y в заштрихованной       *");
            Console.WriteLine(" области                                                                  *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            int y;
            Console.WriteLine("Введите координату точки по x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату точки по y: ");
            y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            if (res == true)
            {
                Console.WriteLine("Ваша точка в нужной области");
            }
            else 
            { 
                Console.WriteLine("Ваша точка в ненужной области");
            }

            
            Console.ReadKey();


        }
    }
}