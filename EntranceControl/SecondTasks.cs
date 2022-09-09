using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
    internal class SecondTasks
    {
        public void showPerimeter()
        {
            try
            {

                Console.Write("Введите x1 => ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y1 => ");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите x2 => ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y2 => \n");
                int y2 = Convert.ToInt32(Console.ReadLine());

                /// <summary>
                /// Нахождение длины первого катета
                /// </summary>
                /// <param name="onekhatets">Первый катет по формуле декартовой координаты</param>
                double onekhatets = Math.Abs(x1 - x2);
                Console.WriteLine("Длина первого катета => " + onekhatets);

                /// <summary>
                /// Нахождение длины второго  катета
                /// </summary>
                /// <param name="twokhatets">Второй катет по формуле декартовой координаты</param>
                double twokhatets = Math.Abs(y1 - y2);
                Console.WriteLine("Длина первого катета => " + twokhatets);

                /// <summary>
                /// Нахождение длины гипотенузы
                /// </summary>
                /// <param name="resultkhatets">Длина гипотенузы</param>
                double resultkhatets = Math.Sqrt(Math.Pow(onekhatets, 2) + Math.Pow(twokhatets, 2));

                Console.WriteLine("Длина гипотенузы => " + resultkhatets);
                /// <summary>
                /// Нахождение периметра и площади прямоугольного треугольника
                /// </summary>
                /// <param name="square">Площадь прямоугольного треугольника </param>
                /// <param name="perim">Периметр прямоугольного треугольника</param>

                double square = (onekhatets * twokhatets) / 2;
                double perim = onekhatets + twokhatets + resultkhatets;

                Console.WriteLine("Площадь => " + square);
                Console.WriteLine("Периметр => " + perim);


            }
            catch
            {
                Console.WriteLine("Что-то пошло не так. Попробуйте еще раз");
            }
          

        }
    }
}
