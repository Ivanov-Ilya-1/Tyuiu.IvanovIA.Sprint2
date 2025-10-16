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
                    res = "понедельник";
                    break;
                case 2:
                    res = "вторник";
                    break;
                case 3:
                    res = "среда";
                    break;
                case 4:
                    res = "четверг";
                    break;
                case 5:
                    res = "пятница";
                    break;
                case 6:
                    res = "суббота";
                    break;
                case 7: 
                    res = "воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День недели должен быть от 1 до 7. Значение {value}");


            }

            return res;

        }
    }
}
