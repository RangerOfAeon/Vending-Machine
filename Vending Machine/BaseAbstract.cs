using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    abstract class FoodAbstract
    {
        public Money money = new Money();
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyFood();
        public abstract void ExamineFood();
        public abstract void UseFood();
    }

    abstract class DrinksAbstract
    {
        public Money money = new Money();
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyDrinks();
        public abstract void ExamineDrinks();
        public abstract void UseDrinks();
    }

    abstract class ToysAbstract
    {
        public Money money = new Money();
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyToy();
        public abstract void ExamineToy();
        public abstract void UseToy();
    }
}
