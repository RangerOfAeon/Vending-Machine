using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Money
    {
        public static int[] TypesOfMoney = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public static int MoneyPool = 0;
        public static int[] Prices = new int[9] { 25, 90, 40, 14, 22, 8, 50, 33, 44, };

        public void AddMoney()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();

                Console.WriteLine("How much money do you want to add? You can choose between:");
                Console.WriteLine("\n1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr.");
                Console.WriteLine("\nEnter 0 to go back.");
                Console.WriteLine($"\nYou currently have: {MoneyPool}kr.");

                string ChooseMoney = Console.ReadLine();

                if (int.TryParse(ChooseMoney, out int result) && result == 1)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[0];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 5)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[1];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 10)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[2];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 20)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[3];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 50)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[4];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 100)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[5];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 500)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[6];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 1000)
                {
                    MoneyPool = MoneyPool + TypesOfMoney[7];
                }
                else if (int.TryParse(ChooseMoney, out result) && result == 0)
                {
                    End = true;
                }
                else if (!int.TryParse(ChooseMoney, out result))
                {
                    Console.WriteLine("Not a number, try again.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Not a correct number, try again.");
                    Console.ReadKey();
                }
            }
        }
        public void Change()
        {
            //foreach (int a; MoneyPool > TypesOfMoney[8]; a++)
            //MoneyPool = MoneyPool - TypesOfMoney[8];
        }
        public void NoMoney()
        {
            Console.WriteLine("\nYou don't have enough money.");
            Console.ReadKey();
        }


    }

   
}
