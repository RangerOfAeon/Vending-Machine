using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class EndChange
    {
        int a;
        int b;
        int c;
        int d;
        int e;
        int f;
        int g;
        int h;

        public void Change()
        {
            while (Money.MoneyPool > 0)
            {
                while (Money.MoneyPool >= Money.TypesOfMoney[7])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[7])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[7];
                        a++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[6])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[6])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[6];
                        b++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[5])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[5])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[5];
                        c++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[4])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[4])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[4];
                        d++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[3])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[3])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[3];
                        e++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[2])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[2])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[2];
                        f++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[1])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[1])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[1];
                        g++;
                    }
                }
                while (Money.MoneyPool >= Money.TypesOfMoney[0])
                {
                    if (Money.MoneyPool >= Money.TypesOfMoney[0])
                    {
                        Money.MoneyPool = Money.MoneyPool - Money.TypesOfMoney[0];
                        h++;
                    }
                }

            }
            Console.WriteLine($"\nYou get back {a}: 1000 bills, {b}: 500 bills, {c}: 100 bills, {d}: 50 bills, {e}: 20 bills, {f}: 10 coins, {g}: 5 coins, {h}: 1 coins.");
        }
    }
}
