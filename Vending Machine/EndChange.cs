using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class EndChange                 // Här är klassen som räknar ut hur mycket växel som användaren får tillbaka, och den skapar även en lista som håller växeln.
    {
        public static List<int> YourMoney = new List<int>();

        public void Change()            // Här börjar metoden som räknar ut växeln.
        {
            while (Money.MoneyPool > 0)         // Här börjar loopen som fortsätter tills maskinen inte har några pengar kvar.
            {
                while (Money.MoneyPool >= Money.TypesOfMoney[7])        // Så länge man har 1000kr eller mer, så tar den bort 1000kr från din MoeyPool, och lägger i 1000
                {                                                                               // i en list.
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[7];
                        YourMoney.Add(Money.TypesOfMoney[7]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[6])        // Samma som ovan fast nu är det 500kr. Sedan blir det 100kr, sedan 50kr osv...
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[6];
                        YourMoney.Add(Money.TypesOfMoney[6]);
                }                                                              
                while (Money.MoneyPool >= Money.TypesOfMoney[5])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[5];
                        YourMoney.Add(Money.TypesOfMoney[5]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[4])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[4];
                        YourMoney.Add(Money.TypesOfMoney[4]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[3])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[3];
                        YourMoney.Add(Money.TypesOfMoney[3]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[2])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[2];
                        YourMoney.Add(Money.TypesOfMoney[2]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[1])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[1];
                        YourMoney.Add(Money.TypesOfMoney[1]);
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[0])
                {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[0];
                        YourMoney.Add(Money.TypesOfMoney[0]);
                }
                                                                        // Här avslutas hela loopen.
            }
            Console.Clear();
            Console.WriteLine("Your change:");          // Här skriver programmet ut användarens växel i en lista, sedan stängs programmet ner.
            foreach (int item in YourMoney)
            {
                Console.WriteLine($"\nOne {item}kr.");
            }
        }
        
        
        
    }
}
