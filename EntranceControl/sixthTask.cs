using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
     class sixthTask
    {
        public void showFibonacci()
        {

            try
            {

                Console.WriteLine("Введите желаемую последовательность => ");
                ulong number = Convert.ToUInt32(Console.ReadLine());

                ulong solve = 0; // хранит предыдущее
                ulong slim = 1; // хранит следующее
                ulong mistack; // настоящее число

                Console.WriteLine("0 - индекс 0");
                for (ulong i = 2; i < number; i++) // выводим 
                {
                    //Console.WriteLine(i);
                    mistack = solve + slim;
                    solve = slim;
                    slim = mistack;
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(mistack + $" - индекс {i}");
                    }
                    else Console.WriteLine("Нечетный индекс!");
                }

            }
            catch
            {
                Console.WriteLine("Что-то пошло не так. Попробуйте еще раз");
            }
            
          
        }


    }
}
