using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovIA.Sprint2.Task5.V3.Lib
{
    public class DataService : ISprint2Task5V3
    {
        public string FindDayName(int value)
        {
            string res;
            switch (value) 
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7: 
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День недели должен быть от 1 до 7. Значение {value}");


            }

            return res;

        }
    }
}
