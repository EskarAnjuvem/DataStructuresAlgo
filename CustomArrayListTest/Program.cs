using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List;

namespace CustomArrayListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList<string> shoppingList = new CustomArrayList<string>();
            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Dragon Fruit");
            shoppingList.Add("Lettuce");

            shoppingList.DisplayList();
            Console.WriteLine("The shopping list is {0} items long", shoppingList.Count);

            string item1 = shoppingList.RemoveAt(2);
            Console.WriteLine("Item removed: {0}", item1);

            shoppingList.Insert("Black Pepper", 2);
            shoppingList.DisplayList();
            Console.WriteLine("The shopping list is {0} items long", shoppingList.Count);

            Console.WriteLine("Dragon Fruit is at index {0}", shoppingList.IndexOf("Dragon Fruit"));
            Console.WriteLine("Water is at index {0}", shoppingList.IndexOf("Water"));

            Console.ReadLine();
        }
    }
}
