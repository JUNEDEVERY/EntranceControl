using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
     class SevenTask
    { 

        public void getAmount()
        {
            try
            {
                double sum = 0; // 
                Console.Write("Введите число n => ");
                double n = Convert.ToDouble(Console.ReadLine());

                for (double i = 1; i <= n; i++)
                {

                    sum += (i / (i + 1.0));
                    if (i == n)
                    {
                        Console.WriteLine(sum);

                    }


                }
            }
            
              catch
            {
                Console.WriteLine("Что-то пошло не так. Попробуйте еще раз");
            }

        }
    }
}
