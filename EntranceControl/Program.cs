using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {

                    Console.WriteLine("1 вариант");
                    Console.WriteLine("1. Программа, выводящая первое введеное число в степень введенного второго числа");
                    Console.WriteLine("2. Вывод периметра и площадь по координатам (x1;y1), (x2;y2)");
                    Console.WriteLine("3. Проверка остатка при делении на 2 и 3");
                    Console.WriteLine("4. Столбик из вашего введенного n впорядке возрастания разрядов");
                    Console.WriteLine("5. Уравнение");
                    Console.WriteLine("6. Числа Фибанначи");
                    Console.WriteLine("7. Сумма первых n членов");
                    Console.WriteLine("8. Лучший результат спортсменов");
                    Console.WriteLine("9. Выход");

                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("1. Программа, выводящая первое введеное число в степень введенного второго числа");
                            TheFirstTasks theFirstTasks = new TheFirstTasks();
                            theFirstTasks.showResult();

                            break;
                        case 2:
                            Console.WriteLine("2. Вывод периметра и площадь по координатам (x1;y1), (x2;y2)");
                            SecondTasks secondTasks = new SecondTasks();
                            secondTasks.showPerimeter();
                            break;
                        case 3:
                            Console.WriteLine("3. Проверка остатка при делении на 2 и 3");
                            ThirdTasks thirdTasks = new ThirdTasks();
                            thirdTasks.showDivision();

                            break;
                        case 4:
                            Console.WriteLine("4. Столбик из вашего введенного n впорядке возрастания разрядов");
                            FourthTask fourthTask = new FourthTask();
                            fourthTask.showSymbols();

                            break;
                        case 5:
                            Console.WriteLine("5. Уравнение");
                            Equation equation = new Equation();
                            equation.getEquation();

                            break;
                        case 6:
                            Console.WriteLine("6. Числа Фибанначи");
                            sixthTask sixthTask = new sixthTask();
                            sixthTask.showFibonacci();
                            break;
                        case 7:
                            Console.WriteLine("7. Сумма первых n членов");
                            SevenTask sevenTask = new SevenTask();
                            sevenTask.getAmount();
                            break;
                        case 8:
                            Console.WriteLine("8. Лучший результат спортсменов");
                            eightTask eightTask = new eightTask();
                            eightTask.getResult();
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Такой задачи нет");
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Вы точно ввели цифру?");
            }
            

        }
    }
}
