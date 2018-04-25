using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Machine
    {
       

        public static string[] Names = new string[9] { "Sandwich", "Pizza", "Hamburger", "Cola", "Coffee", "Water", "Car", "Jojo", "Figure",};

        public static string[] Desc = new string[9] {"Two bread slices with salmon and mayonnaise.", "Flat hot bread with fungus, sausage and corn.",
            "Meat in bun with banana and a onion.", "Soft drink that taste like cola and cinnamon.",
            "Energy drink that is bitter and with liqour.", "Plain water from Mount Everest.", "Model vehicle for small people.",
            "A tool to learn psychic powers.", "Action dolls to learn about thyself." };

        static void Main(string[] args)
        {
            Money money = new Money();
            DoWhat doWhat = new DoWhat();
            bool EndMachine = false;
            while (EndMachine == false)
            {
                Console.Clear();

                Console.WriteLine("What do you want to do?");
                Console.WriteLine($"\nYou currently have: {Money.MoneyPool}kr.");
                Console.WriteLine("\nPress [A] to add money.");
                Console.WriteLine("\nPress [B] to buy products.");
                Console.WriteLine("\nPress [E] to examine products.");
                Console.WriteLine("\nPress [U] to use products.");
                Console.WriteLine("\nPress [S] to stop shopping.");

                var startChoose = Console.ReadKey(true);

                switch (startChoose.Key)
                {
                    case ConsoleKey.A:
                        money.AddMoney();
                        break;
                    case ConsoleKey.B:
                        doWhat.BuyWhat();
                        break;
                    case ConsoleKey.E:
                        doWhat.ExamineWhat();
                        break;
                    case ConsoleKey.U:
                        doWhat.UseWhat();
                        break;
                    case ConsoleKey.S:
                        EndMachine = true;
                        break;
                    default:
                        
                        break;
                }
            }
        }
        public void WrongInput()
        {
            Console.WriteLine("\nWrong input, try again.");
            Console.ReadKey(true);
        }
    }
}
