using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Toy : ToysAbstract
    {
        Machine machine = new Machine();

        public override void BuyToy()                   // Den här klassen fungerar likadant som Foodklassen, så kolla på den för kommentarer. 
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of toy do you want to buy?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to buy a {Machine.Names[6]} for {Money.Prices[6]}kr.");
                Console.WriteLine($"\nPress [J] to buy a {Machine.Names[7]} for {Money.Prices[7]}kr.");
                Console.WriteLine($"\nPress [F] to buy a {Machine.Names[8]} for {Money.Prices[8]}kr.");
                Console.WriteLine($"\nPress [B] to go back.");


                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        if (Money.MoneyPool >= Money.Prices[6])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[6];
                            a++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[6]} for {Money.Prices[6]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.J:
                        if (Money.MoneyPool >= Money.Prices[7])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[7];
                            b++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[7]} for {Money.Prices[7]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.F:
                        if (Money.MoneyPool >= Money.Prices[8])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[8];
                            c++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[8]} for {Money.Prices[8]}kr.");
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

        public override void ExamineToy()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of toy do you want to examine?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to examine the {Machine.Names[6]}, {Money.Prices[6]}kr.");
                Console.WriteLine($"\nPress [J] to examine the {Machine.Names[7]}, {Money.Prices[7]}kr.");
                Console.WriteLine($"\nPress [F] to examine the {Machine.Names[8]}, {Money.Prices[8]}kr.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("\n" + Machine.Desc[6]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.J:
                        Console.WriteLine("\n" + Machine.Desc[7]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.F:
                        Console.WriteLine("\n" + Machine.Desc[8]);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        Machine.WrongInput();
                        Console.ReadKey();
                        break;
                }
            }
        }

        public override void UseToy()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of toy do you want to use?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [C] to use the {Machine.Names[6]}, you have {a} left.");
                Console.WriteLine($"\nPress [J] to ues the {Machine.Names[7]}, you have {b} left.");
                Console.WriteLine($"\nPress [F] to ues the {Machine.Names[8]}, you have {c} left.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.C:
                        if (a > 0)
                        {
                            a--;
                            Console.WriteLine($"\nYou played with the {Machine.Names[6]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[6]}");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.J:
                        if (b > 0)
                        {
                            b--;
                            Console.WriteLine($"\nYou played with the {Machine.Names[7]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[7]}");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.F:
                        if (c > 0)
                        {
                            c--;
                            Console.WriteLine($"\nYou played with the {Machine.Names[8]}.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine($"\nYou don't have any {Machine.Names[8]}");
                            Console.ReadKey();
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
