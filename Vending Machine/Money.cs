using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Money                 // Här är variabler som används av Food, Drinks, Toy. MoneyPool används av alla klasser förutom BaseAbstract-klasserna. 
    {
        public static int[] TypesOfMoney = new int[8] { 1, 5, 10, 20, 50, 100, 500, 1000 };         // Hur mycket pengar man kan lägga i maskinen.          
        public static int MoneyPool = 0;                                                            // Hur mycket pengar användaren har.
        public static int[] Prices = new int[9] { 25, 90, 40, 14, 22, 8, 50, 33, 44, };             // Hur mycket pengar produkterna kostar.

        public void AddMoney()          // Här är metoden för att lägga i mer pengar i maskinen. 
        {
            bool End = false;
            while (End == false)        // Här börjar loopen.
            {
                Console.Clear();

                Console.WriteLine("How much money do you want to add? You can choose between:");        // Här frågar programmet hur mycket pengar användaren vill lägga i
                Console.WriteLine("\n1kr, 5kr, 10kr, 20kr, 50kr, 100kr, 500kr, 1000kr.");               // maskinen, vilka mynt/sedlar går i, hur man går tillbaka &
                Console.WriteLine("\nEnter 0 to go back.");                                             // Hur mycket pengar man för tillfället har.
                Console.WriteLine($"\nYou currently have: {MoneyPool}kr.");

                string ChooseMoney = Console.ReadLine();

                if (int.TryParse(ChooseMoney, out int result) && result == 1)                           // Om man skriver rätt mängd, så får man den mängden, som om man 
                {                                                                                       // skriver 1, så får man 1kr, och om man skriver 100, så får man
                    MoneyPool = MoneyPool + TypesOfMoney[0];                                            // 100kr.
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
                else if (!int.TryParse(ChooseMoney, out result))                                   // Om man skriver in något annat ett nummer, så får man försöka igen.
                {
                    Console.WriteLine("Not a number, try again.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Not a correct number, try again.");                         // Om man skriver ett fel nummer, så får man försöka igen.
                    Console.ReadKey();
                }
            }
        }
        public void NoMoney()
        {
            Console.WriteLine("\nYou don't have enough money.");                // Här är metoden som skriver att man inte har tillräckligt mycket pengar.
            Console.ReadKey();
        }
        

    }

   
}
