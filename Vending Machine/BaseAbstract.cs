using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    abstract class FoodAbstract                             // Här är den abstracta klassen för Food. Den innehåller en isntans av klassen Money, en bool som aktiverar
    {                                                       // loopen, tre variabler som heter a, b & c, som innehåller hur många produkter man har av varje Food.
        public Money money = new Money();                   // Tillslut, så finns det de tre metoderna som används för att köpa, granska och använda.
        public bool End = false;
        public static int a;
        public static int b;
        public static int c;
        public abstract void BuyFood();
        public abstract void ExamineFood();
        public abstract void UseFood();
    }

    abstract class DrinksAbstract                           // Här är den abstracta klassen för Drinks, och den fungerar som den abstracta Foodklassen.
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
        
    abstract class ToysAbstract                         // Här är den abstracta klassen för Toy, och den fungerar som den abstracta Foodklassen.
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
