using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
     class ThirdTasks
    {
        public void showDivision()
        {
            try
            {


                Console.Write("Введите число => ");
                double m = Convert.ToDouble(Console.ReadLine());
                double a = m % 2;
                double b = m % 3;
                Console.WriteLine($"Число {m} имеет остаток от деления на 2 => {a}");
                Console.WriteLine($"Число {m} имеет остаток от деления на 3 => {b}");
                if (a == b)
                {
                    Console.WriteLine($"Число {m} дает одинаковый остаток на 2 и на 3");

                }
                else
                {
                    Console.WriteLine($"Число {m} не имеет одинакового остатка");
                }


            }

            catch
            {
                Console.WriteLine("Что-то пошло не так. Попробуйте еще раз");
            }
        }
    }
}
