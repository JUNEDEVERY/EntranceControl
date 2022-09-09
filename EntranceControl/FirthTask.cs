using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
    class Equation
    {
        public  void getEquation()
        {
            try
            {
                Console.WriteLine("1 + sin√х+1 / cos(12y-4)");
                Console.Write("Введите x => ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y => ");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Результат уравнения => " + (1.0 + (Math.Sin(Math.Sqrt(x + 1.0)))) / (Math.Cos(12 * y - 4)));
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка. Давайте еще раз.");
            }
           
        }




    }
}
