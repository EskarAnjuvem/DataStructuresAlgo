using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicLinkedList;

namespace DynamicListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicList<string> shoppingList = new DynamicList<string>();
            shoppingList.Add("Milk");
            shoppingList.Add("Butter");
            shoppingList.Add("Yogurt");
            shoppingList.Add("Chicken");
            shoppingList.Add("Bread");
            shoppingList.Add("Coriander");
            shoppingList.Add("Onions");

            shoppingList.DisplayList();

            Console.WriteLine("Removed :" + shoppingList.RemoveAt(3));
            Console.WriteLine("Items Remaining: {0}",shoppingList.Count);

            shoppingList.DisplayList();

            Console.WriteLine("Removed :" + shoppingList.RemoveAt(2));
            Console.WriteLine("Items Remaining: {0}", shoppingList.Count);

            shoppingList.DisplayList();

            Console.WriteLine("Removed :" + shoppingList.RemoveAt(0));
            Console.WriteLine("Items Remaining: {0}", shoppingList.Count);

            shoppingList.DisplayList();

            Console.WriteLine("Removed :" + shoppingList.RemoveAt(3));
            Console.WriteLine("Items Remaining: {0}", shoppingList.Count);

            shoppingList.DisplayList();

            Console.ReadLine();
        }

    }
}
