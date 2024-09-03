using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> printingLine = new Queue<string>();
            printingLine.Enqueue("Page One");
            printingLine.Enqueue("Page Two");
            printingLine.Enqueue("Page Three");
            printingLine.Enqueue("Page Four");
            printingLine.Enqueue("Page Five");

            while(printingLine.Count > 0)
            {
                string message = printingLine.Dequeue();
                Console.WriteLine(message);
            }

            Console.ReadLine();

        }
    }
}
