using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class DoWhat
    {
        Food food = new Food();
        Drink drink = new Drink();
        Toy toy = new Toy();
        Machine machine = new Machine();

        public void BuyWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What type of product do you want to buy?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine("\nPress [F] to buy food.");
                Console.WriteLine("\nPress [D] to buy drinks.");
                Console.WriteLine("\nPress [T] to buy toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        food.BuyFood();
                        break;
                    case ConsoleKey.D:
                        drink.BuyDrinks();
                        break;
                    case ConsoleKey.T:
                        toy.BuyToy();
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
        public void ExamineWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want do examine?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine("\nPress [F] to examine foods.");
                Console.WriteLine("\nPress [D] to examine drinks.");
                Console.WriteLine("\nPress [T] to examine toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        food.ExamineFood();
                        break;
                    case ConsoleKey.D:
                        drink.ExamineDrinks();
                        break;
                    case ConsoleKey.T:
                        toy.ExamineToy();
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
        public void UseWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want to use?");
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");
                Console.WriteLine("\nPress [F] to use food.");
                Console.WriteLine("\nPress [D] to use drinks.");
                Console.WriteLine("\nPress [T] to use toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:
                        food.UseFood();
                        break;
                    case ConsoleKey.D:
                        drink.UseDrinks();
                        break;
                    case ConsoleKey.T:
                        toy.UseToy();
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
       
       
    }
}
