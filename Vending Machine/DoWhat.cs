using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class DoWhat                                             // Här är klassen som har metoderna som bestämmer om man vill köpa Food, Drinks, eller toy, om man vill
    {                                                        // granska Food, Dricka osv...
        Food food = new Food();
        Drink drink = new Drink();
        Toy toy = new Toy();                                 // Instanserna som metoderna använder.
        Machine machine = new Machine();                    

        public void BuyWhat()                                // Här börjar metoden som frågar vilken sort produkt användaren vill köpa.
        {
            bool End = false;
            while (End == false)                             // Här börjar loopen.
            {
                Console.Clear();
                Console.WriteLine("What type of product do you want to buy?");              // Här frågar programmet vad man vill göra, och man kan välja emellan att
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");           // köpa Food, Drinks och Toy.
                Console.WriteLine("\nPress [F] to buy food.");
                Console.WriteLine("\nPress [D] to buy drinks.");
                Console.WriteLine("\nPress [T] to buy toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();                             // Här är switch-menyn som man väljar vad man vill köpa, beronde på vilken tangent man tyrkte på. 
                switch (choose.Key)
                {
                    case ConsoleKey.F:                                      // Om man valde att köpa Food, så kallar programmet på BuyFood-metoden.
                        food.BuyFood();
                        break;
                    case ConsoleKey.D:                                      // Om man valde att köpa Drinks, så kallar programmet på BuyDrinks-metoden.
                        drink.BuyDrinks();
                        break;
                    case ConsoleKey.T:                                      // Om man valde att köpa Toy, så kallar programmet på BuyToy-metoden.
                        toy.BuyToy();
                        break;
                    case ConsoleKey.B:                                      // Om man väljer att gå tillbaka, så avslutas loopen och man går tillbaka.
                        End = true;
                        break;
                    default:                                                // Om man trycker fel, så kallar programmet på WrongInput-metoden och loopar tillbaka.
                        Machine.WrongInput();
                        break;
                }
            }                                       // Här slutar loopen och metoden.
        }
        public void ExamineWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want do examine?");                              // Här frågar programmet vad man vill göra, och man kan välja emellan att
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");               // granska Food, Drinks och Toy.
                Console.WriteLine("\nPress [F] to examine foods.");
                Console.WriteLine("\nPress [D] to examine drinks.");
                Console.WriteLine("\nPress [T] to examine toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {                                                            
                    case ConsoleKey.F:                                          // Om man valde att granska Food, så kallar programmet på ExamineFood-metoden.
                        food.ExamineFood();                           
                        break;
                    case ConsoleKey.D:                                          // Om man valde att granska Drinks, så kallar programmet på ExamineDrinks-metoden.
                        drink.ExamineDrinks();
                        break;
                    case ConsoleKey.T:                                          // Om man valde att granska Toy, så kallar programmet på ExamineToy-metoden.
                        toy.ExamineToy();
                        break;
                    case ConsoleKey.B:                                          // Om man väljer att gå granska, så avslutas loopen och man går tillbaka.
                        End = true;
                        break;
                    default:                                                    // Om man trycker fel, så kallar programmet på WrongInput-metoden och loopar tillbaka.
                        Machine.WrongInput();
                        break;
                }
            }                                                // Här slutar loopen och metoden.
        }
        public void UseWhat()
        {
            bool End = false;
            while (End == false)
            {
                Console.Clear();
                Console.WriteLine("What do you want to use?");                                  // Här frågar programmet vad man vill göra, och man kan välja emellan att
                Console.WriteLine($"\nYour current money: {Money.MoneyPool}kr.");               // använda Food, Drinks och Toy.
                Console.WriteLine("\nPress [F] to use food.");
                Console.WriteLine("\nPress [D] to use drinks.");
                Console.WriteLine("\nPress [T] to use toys.");
                Console.WriteLine("\nPress [B] to go back.");

                var choose = Console.ReadKey();
                switch (choose.Key)
                {
                    case ConsoleKey.F:                                      // Om man valde att använda Food, så kallar programmet på UseFood-metoden.
                        food.UseFood();
                        break;
                    case ConsoleKey.D:                                      // Om man valde att använda Drinks, så kallar programmet på UseDrinks-metoden.
                        drink.UseDrinks();
                        break;
                    case ConsoleKey.T:                                      // Om man valde att använda Toy, så kallar programmet på UseToy-metoden.
                        toy.UseToy();
                        break;
                    case ConsoleKey.B:                                      // Om man väljer att gå använda, så avslutas loopen och man går tillbaka.
                        End = true;
                        break;
                    default:                                                // Om man trycker fel, så kallar programmet på WrongInput-metoden och loopar tillbaka.
                        Machine.WrongInput();
                        break;
                }
            }
        }                                                     // Här slutar loopen och metoden.


    }
}
