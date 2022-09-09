using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
     class TheFirstTasks
    {
        public  void showResult()
        {

            try{


                Console.Write("Введите первое число => ");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число => ");
                double second = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Результат возведенного первого числа на степень второго =>  " + Math.Pow(first, second));



            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка. Давайте еще раз.");
            }



        }

       

    }
}
