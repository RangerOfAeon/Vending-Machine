using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Food : FoodAbstract
    {
        Machine machine = new Machine();

        public override void BuyFood()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("Which type of food did you want to buy?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [S] to buy a {Machine.Names[0]} for {Money.Prices[0]}kr.");
                Console.WriteLine($"\nPress [P] to buy a {Machine.Names[1]} for {Money.Prices[1]}kr.");
                Console.WriteLine($"\nPress [H] to buy a {Machine.Names[2]} for {Money.Prices[2]}kr.");
                Console.WriteLine($"\nPress [B] to go back.");

                var choose = Console.ReadKey(true);

                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        if (Money.MoneyPool >= Money.Prices[0])
                        {
                            Money.MoneyPool = Money.MoneyPool - Money.Prices[0];
                            a++;
                            Console.WriteLine($"\nYou have bought the {Machine.Names[0]} for {Money.Prices[0]}kr.");
                            Console.ReadKey();
                        }
                        else
                        {
                            money.NoMoney();
                        }
                        break;
                    case ConsoleKey.P:
                        if (Money.MoneyPool >= Money.Prices[1])
                        {
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
                        if (Money.MoneyPool >= Money.Prices[2])
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
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        machine.WrongInput();
                        break;
                }
            }
        }
   
        public override void ExamineFood()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to examine?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [S] to examine the {Machine.Names[0]}.");
                Console.WriteLine($"\nPress [P] to examine the {Machine.Names[1]}.");
                Console.WriteLine($"\nPress [H] to examine the {Machine.Names[2]}.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
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
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        machine.WrongInput();
                        break;
                }
            }
        }

        public override void UseFood()
        {
            End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What kind of food do you want to use?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine($"\nPress [S] to use the {Machine.Names[0]}, you have {a} left.");
                Console.WriteLine($"\nPress [P] to ues the {Machine.Names[1]}, you have {b} left.");
                Console.WriteLine($"\nPress [H] to ues the {Machine.Names[2]}, you have {c} left.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey(true);
                switch (choose.Key)
                {
                    case ConsoleKey.S:
                        a--;
                        Console.WriteLine($"\nYou ate the {Machine.Names[0]}.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.P:
                        b--;
                        Console.WriteLine($"\nYou ate the {Machine.Names[1]}.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.H:
                        c--;
                        Console.WriteLine($"\nYou ate the {Machine.Names[2]}.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.B:
                        End = true;
                        break;
                    default:
                        machine.WrongInput();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
