using Tyuiu.IvanovIA.Sprint2.Task4.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task4.V8
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine(" Тема : Тернарный оператор                                                *");
            Console.WriteLine(" Задание #4                                                               *");
            Console.WriteLine(" Вариант #8                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine(" тернарного оператора, где пользователь вводит значения x,y с клавиатуры   *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;
            double y;
            double res;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            res = ds.Calculate(x,y);

            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();


        }
    }
}