using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
     class FourthTask
    {
        public void showSymbols()
        {

            try
            {
                Console.Write("Введите число n => ");
                string number = Console.ReadLine().ToString();
                int n;
                // try parse преобразовывает строку к нужному типу и возвращает тру или фолс
                // в данном случае мы парсим данные из  строки, а вторым параметром мы передаем вторым параметром переменную, куда нужно засунуть парснутую строку
                // то есть вводим строку, к примеру, 456, если это число( а т.к нам нужен именно инт), то он успешно парсит
                // а если мы введем 31231вфввфв, то парснуть не получится, но ошибки не будет. ведь tryparse - пробует запарсить


                if (int.TryParse(number, out n))
                {
                    foreach (char s in number.ToCharArray().Reverse()) // разбиваем на символы 147 => 7 4 1
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Непредвиденная ошибка. Давайте еще раз.");


            }
           
            
           




        }
    }
}
