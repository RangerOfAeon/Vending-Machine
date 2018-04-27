using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Machine                                 // Huvudklassen, där programmet går igenom. Här under så finns det 2 arrays, den ena är fylld med produktnamn, den
    {                                             // andra är fylld med produktbeskrivningar, och båda används av klasserna Food, Drinks & Toy. 

        public static string[] Names = new string[9] { "Sandwich", "Pizza", "Hamburger", "Cola", "Coffee", "Water", "Car", "Jojo", "Figure",};

        public static string[] Desc = new string[9] {"Two bread slices with salmon and mayonnaise.", "Flat hot bread with fungus, sausage and corn.",
            "Meat in bun with banana and a onion.", "Soft drink that taste like cola and cinnamon.",
            "Energy drink that is bitter and with liqour.", "Plain water from Mount Everest.", "Model vehicle for small people.",
            "A tool to learn psychic powers.", "Action dolls to learn about thyself." };

        static void Main(string[] args)                         // Här finns instanserna som huvudmetoden bevhöver, och här börjar också huvudloopen.
        {
            Money money = new Money();
            DoWhat doWhat = new DoWhat();
            EndChange endChange = new EndChange();
            bool EndMachine = false;
            while (EndMachine == false)
            {
                Console.Clear();

                Console.WriteLine("What do you want to do?");                               // Här frågar programmet vad anvöndare vill göra, och den visar vad man kan
                Console.WriteLine($"\nYou currently have: {Money.MoneyPool}kr.");           // välja, som att lägga till pengar, eller köpa produkter.
                Console.WriteLine("\nPress [A] to add money.");
                Console.WriteLine("\nPress [B] to buy products.");
                Console.WriteLine("\nPress [E] to examine products.");
                Console.WriteLine("\nPress [U] to use products.");
                Console.WriteLine("\nPress [S] to stop shopping.");

                var startChoose = Console.ReadKey(true);                        // Här är de olika resultaten beroende på man valde.
                                                                                     
                switch (startChoose.Key)
                {
                    case ConsoleKey.A:                                          // Om man valde att lägga i mer pengar, så kallar programmet på AddMoney-metoden.
                                                                                  
                        money.AddMoney();
                        break;
                    case ConsoleKey.B:                                          // Om man valde att köpa en produkt, så kallar programmet på BuyWhat-metoden.
                        doWhat.BuyWhat();
                        break;
                    case ConsoleKey.E:                                          // Om man valde att granska en produkt, så kallar programmet på ExamineWhat-metode.
                        doWhat.ExamineWhat();
                        break;
                    case ConsoleKey.U:                                          // Om man valde att använda en produkt, så kalar på programmet på UseWhat-metoden.
                        doWhat.UseWhat();
                        break;
                    case ConsoleKey.S:                                          // Om man valde att sluta handla, så avslutas loopen, så programmet kallar på Change-metoden.
                        EndMachine = true;
                        endChange.Change();
                        Console.ReadKey();
                        break;
                    default:                                                    // Om man tryckte fel, så kallar programmet på WrongIput-metoden, och det loopar tillbaka.
                        WrongInput();
                        break;
                }
            }                                                // Här avslutas huvudloopen.
        }
        public static void WrongInput()
        {
            Console.WriteLine("\nWrong input, try again.");                      // Här är metoden som skriver att man tryckte fel.
            Console.ReadKey(true);
        }
    }
}
