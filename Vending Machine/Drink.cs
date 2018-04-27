using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Drink : DrinksAbstract
    {
        Machine machine = new Machine();

        public override void BuyDrinks()            // Den här klassen fungerar likadant som Foodklassen, så kolla på den för kommentarer. 
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What typ of drink do you want to buy?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to buy a {Machine.Names[3]} for {Money.Prices[3]}kr.");
                Console.WriteLine($"\nPress [K] to buy a {Machine.Names[4]} for {Money.Prices[4]}kr.");
                Console.WriteLine($"\nPress [W] to buy a {Machine.Names[5]} for {Money.Prices[5]}kr.");
                Console.WriteLine($"\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        if (Money.MoneyPool >= Money.Prices[3])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[3];
                            a++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[3]} for {Money.Prices[3]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.K:
                        if (Money.MoneyPool >= Money.Prices[4])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[4];
                            b++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[4]} for {Money.Prices[4]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.W:
                        if (Money.MoneyPool >= Money.Prices[5])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[5];
                            c++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[5]} for {Money.Prices[5]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();
                        break;
                }
            }
        }

        public override void ExamineDrinks()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of drink do you want to examine?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to examine the {Machine.Names[3]}, {Money.Prices[3]}kr.");
                Console.WriteLine($"\nPress [K] to examine the {Machine.Names[4]}, {Money.Prices[4]}kr.");
                Console.WriteLine($"\nPress [W] to examine the {Machine.Names[5]}, {Money.Prices[5]}kr.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("\n" + Machine.Desc[3]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine("\n" + Machine.Desc[4]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("\n" + Machine.Desc[5]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();
                        break;
                }
            }
        }

        public override void UseDrinks()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of drink do you want to use?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to use the {Machine.Names[3]}, you have {a} left.");
                Console.WriteLine($"\nPress [K] to ues the {Machine.Names[4]}, you have {b} left.");
                Console.WriteLine($"\nPress [W] to ues the {Machine.Names[5]}, you have {c} left.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        if (a > 0)
                        {
                            a--;
                            Console.WriteLine($"\nYou drank the {Machine.Names[3]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[3]}");
                        }
                        break;
                    case ConsoleKey.K:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"\nYou drank the {Machine.Names[4]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[4]}");
                        }
                        break;
                    case ConsoleKey.W:
                        if (c > 0)
                        {
                            c--;
                            Console.WriteLine($"\nYou drank the {Machine.Names[5]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[5]}");
                        }
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
