using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
    class eightTask
    {
        public void getResult()
        {
            try
            {
                Dictionary<string, double> people = new Dictionary<string, double>();
                Console.WriteLine("Введите время первого плавца => ");
                double firstswimmer = Convert.ToDouble(Console.ReadLine());
                people.Add("Первый плавец", firstswimmer);
                Console.WriteLine("Введите время второго плавца => ");
                double secondswimmer = Convert.ToDouble(Console.ReadLine());
                people.Add("Второй плавец", secondswimmer);
                Console.WriteLine("Введите время третьего плавца => ");
                double thirdswimmer = Convert.ToDouble(Console.ReadLine());
                people.Add("Третий плавец", thirdswimmer);

                Console.WriteLine("Лучшее время:");
                foreach (var str in people.Where(x => x.Value == people.FirstOrDefault(a => a.Value == people.Values.Min()).Value))
                {

                    Console.WriteLine(str.Key + " - " + str.Value);
                }
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так. Попробуем еще раз?.");
            }
            




            // if (firstswimmer < secondswimmer && firstswimmer < thirdswimmer)
            //     Console.WriteLine($"Первый плавец победил о следующем временем -  {firstswimmer}");
            // if (secondswimmer < firstswimmer && secondswimmer < thirdswimmer)
            //     Console.WriteLine($"Второй плавец  -  {secondswimmer}");
            // if (thirdswimmer < firstswimmer && thirdswimmer < secondswimmer)
            //     Console.WriteLine($"Это результат третьего победителя заплыва, проплывшего за это время  -  {thirdswimmer}");
            // if (secondswimmer == firstswimmer && secondswimmer < thirdswimmer)
            // {
            //     Console.WriteLine($"Лучший результат у первого и второго плавца, проплывших за {firstswimmer} {secondswimmer} ");
            // }
            // if (thirdswimmer == firstswimmer && thirdswimmer < secondswimmer)
            // {
            //     Console.WriteLine($"Лучший результат у первого и третьего плавца, проплывших за {firstswimmer} {thirdswimmer} ");

            // }
            // if(secondswimmer == thirdswimmer && secondswimmer < firstswimmer)
            // {
            //     Console.WriteLine($"Лучший результат у второго и третьего плавца, проплывших за {secondswimmer} {thirdswimmer} ");

            // }
            //else if (firstswimmer == thirdswimmer && firstswimmer  == secondswimmer)
            // {
            //     Console.WriteLine("Все трое плавцов проплыли с одинаковым результатом! ");
            // }

        }
    }
}
