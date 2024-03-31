using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3___Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру Blackjack! Сколько у вас карт на руках?");
            int amountOfCards = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите пожалуйста номинал всех карт");
            int result = 0;

            for (int i = 0; i < amountOfCards; i++)
            {
                if (i == 0)
                {
                    Console.Write("Введите номинал первой карты: ");
                }
                else if (i < amountOfCards)
                {
                    Console.Write("Введите номинал следующей карты: ");
                }
                string nominal = Console.ReadLine();
                switch (nominal)
                    {
                        case "2":
                            result += 2;
                            break;
                        case "3":
                            result += 3;
                            break;
                        case "4":
                            result += 4;
                            break;
                        case "5":
                            result += 5;
                            break;
                        case "6":
                            result += 6;
                            break;
                        case "7":
                            result += 7;
                            break;
                        case "8":
                            result += 8;
                            break;
                        case "9":
                            result += 9;
                            break;
                        case "10":
                            result += 10;
                            break;
                        case "J":
                            result += 10;
                            break;
                        case "Q":
                            result += 10;
                            break;
                        case "K":
                            result += 10;
                            break;
                        case "T":
                            result += 10;
                            break;
                    }
                
                if (i == amountOfCards)
                {
                    break;
                }
            }
            if (result > 21)
            {
                Console.WriteLine("Сумма ваших карт: " + result + "\nВы проиграли!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Сумма ваших карт: " + result);
                Console.ReadKey();
            }
        }
    }
}
