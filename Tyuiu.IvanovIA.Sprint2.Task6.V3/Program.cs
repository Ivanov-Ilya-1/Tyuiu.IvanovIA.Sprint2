using Tyuiu.IvanovIA.Sprint2.Task6.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint2.Task6.V3
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
            Console.WriteLine(" Задание #6                                                               *");
            Console.WriteLine(" Вариант #3                                                               *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #2                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Написать программу, которая использует сокращенную форму записи оператора*");
            Console.WriteLine(" switch вычисляет требуемое значение и возвращает результат.              *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int x;
            string res;
            Console.WriteLine("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());

            res = ds.FindDayName(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();


        }
    }
}