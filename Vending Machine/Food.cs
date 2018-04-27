using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Food : FoodAbstract                       // Här är klassen för att köpa, granska och använda Food, och det finns en instans från Machine, och den ärver från 
    {                                               // abstactklassen för food.
        Machine machine = new Machine();

        public override void BuyFood()          // Här börjar metoden för att köpa Foodprodukter.
        {
            End = false;
            while (End == false)                // Här börjar loopen.
            {
                Console.Clear();
                Console.WriteLine("Which type of food did you want to buy?");                                       // Här frågar programmet vad användaren vill köpa, och
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");                                   // skriver alternativen.
                Console.WriteLine($"\nPress [S] to buy a {Machine.Names[0]} for {Money.Prices[0]}kr.");
                Console.WriteLine($"\nPress [P] to buy a {Machine.Names[1]} for {Money.Prices[1]}kr.");
                Console.WriteLine($"\nPress [H] to buy a {Machine.Names[2]} for {Money.Prices[2]}kr.");
                Console.WriteLine($"\nPress [B] to go back.");

                var choose = Console.ReadKey(true);

                switch (choose.Key)                             // Här väljer användaren vad den vill köpa.
                {
                    case ConsoleKey.S:
                        if (Money.MoneyPool >= Money.Prices[0])         // Om användaren har råd, så dras priset från användarens moneypool, och man får en produkt, och
                        {                                                                               // Programmet skriver ut det.
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[0];
                            a++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[0]} for {Money.Prices[0]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();                    // Om användaren inte har råd, så skriver programmet det.
                        }
                        break;
                    case ConsoleKey.P:
                        if (Money.MoneyPool >= Money.Prices[1])             // Samma som om man skulle vilja köpa produkten inan, fast man får en annan produkt som har
                        {                                                                       // ett annat pris.
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[1];
                            b++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[1]} for {Money.Prices[1]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.H:
                        if (Money.MoneyPool >= Money.Prices[2])             // Också samma.
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[2];
                            c++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[2]} for {Money.Prices[2]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.B:                  // Här går man tillbaka till förra menyn.
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();           // Om man trycker på fel tangent, så loopar den tillbaka.
                        break;
                }
            }                                           // Här avslutas loopen och metoden.
        }
   
        public override void ExamineFood()              // Här är metoden för att granska Foodprodukterna.
        {
            End = false;
            while (End == false)                        // Här börjar loopen.
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to examine?");                 // Programmet frågar vad användaren vill granska.
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [S] to examine the {Machine.Names[0]}, {Money.Prices[0]}kr.");
                Console.WriteLine($"\nPress [P] to examine the {Machine.Names[1]}, {Money.Prices[1]}kr.");
                Console.WriteLine($"\nPress [H] to examine the {Machine.Names[2]}, {Money.Prices[2]}kr.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);                 // Här väljer användaren vad den vill granska.
                switch (choose.Key)
                {
                    case ConsoleKey.S:                                  // Programmet skriver ut beskrigen på produkten.
                        Console.WriteLine("\n" + Machine.Desc[0]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("\n" + Machine.Desc[1]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.H:
                        Console.WriteLine("\n" + Machine.Desc[2]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:                                  // Man går tillbaka till förra menyn.
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();                           // Programmet skriver att man har valt fel tangent, och loopar tillbaka.
                        break;
                }
            }
        }

        public override void UseFood()                  // Här är metoden för att använda Foodprodukterna.
        {
            End = false;
            while (End == false)                        // Här börjar loopen.
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to use?");                                 // Här frågar programmet vilken produkt som användaren vill
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");                           // använda.
                Console.WriteLine($"\nPress [S] to use the {Machine.Names[0]}, you have {a} left.");
                Console.WriteLine($"\nPress [P] to ues the {Machine.Names[1]}, you have {b} left.");
                Console.WriteLine($"\nPress [H] to ues the {Machine.Names[2]}, you have {c} left.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);                 // Här väljer användaren.
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (a > 0)                      // Om användaren har mer än 0 av produkten, så används den, och det skrivs ut att man åt den.
                        {
                            a--;
                            Console.WriteLine($"\nYou ate the {Machine.Names[0]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else                                // Om användaren inte har några kvar, så skriver programmet det.
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[0]}");
                        }
                        break;
                    case ConsoleKey.P:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"\nYou ate the {Machine.Names[1]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[1]}");
                        }
                        break;
                    case ConsoleKey.H:
                        if (b > 0)
                        {
                            c--;
                            Console.WriteLine($"\nYou ate the {Machine.Names[2]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[2]}");
                        }
                        break;
                    case ConsoleKey.B:                      // Här går man tillbaka till den förra menyn.
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();               // Om man trycker på fel tangent, så skriver programmet det och loopar tillbaka.
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }                                               // Här slutar loopen och metoden.
        }
    }
}
