using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр цилиндра");
            double d =
                double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра");
            double l =
            double.Parse(Console.ReadLine());
            Console.WriteLine("Найдем объём цилиндра");
            double с = (Math.PI * d * d / 4) * l;
                Console.WriteLine("Объем цилиндра равен" + с );
            Console.WriteLine("Найдем сторону равностороннего треугольника в основании");
            double a = 3 * d / (2 * Math.Sqrt(3)); 
                 Console.WriteLine("Сторона равностороннего треугольника в основании равна" + a );
            Console.WriteLine("Найдем объём материала, ушедшего в отход");
            double v = с - ( (l * a * a * Math.Sqrt(3)) / 4);
            Console.WriteLine("Объём материала, ушедшего в отход равен" + v );
            Console.WriteLine("Найдем процент материала, ушедшего в отход");
            double o = (v * 100) / с ;
                Console.WriteLine("Процент материала, ушедшего в отход равен" + o);





        }
    }
}
