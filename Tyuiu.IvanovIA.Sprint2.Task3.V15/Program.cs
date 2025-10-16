using Tyuiu.IvanovIA.Sprint2.Task3.V15.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task3.V15
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
            Console.WriteLine(" Задание #3                                                               *");
            Console.WriteLine(" Вариант #15                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу, которая вычисляет требуемое значение функции Y       *");
            Console.WriteLine(" с использованием вложенных оператор if-else,где пользователь вводит      *");
            Console.WriteLine(" значение переменной X с клавиатуры. Округлить полученное значение до трех*");                                   
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            double x;
            double res;
            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            res = ds.Calculate(x);
            
            Console.WriteLine("Ответ: " +  res);
            Console.ReadKey();


        }
    }
}