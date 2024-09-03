using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBuiltIn
{
    internal class Program
    {
        static List<int> GetPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();
            for (int num = start; num <= end; num++)
            {
                double sqrt = Math.Sqrt(num);
                bool prime = true;

                for (int divisor = 2; divisor <= sqrt; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    primesList.Add(num);
                }
            }

            return primesList;
        }

        static List<int> Union(List<int> first, List<int> second)
        {
            List<int> union = new List<int>();
            union.AddRange(first);
            foreach (var item in second)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union;
        }

        static List<int> Intersect(List<int> first, List<int> second)
        {
            List<int> intersection = new List<int>();
            intersection.AddRange(first);

            for (int i = intersection.Count-1; i >= 0; i--)
            {
                if (!second.Contains(intersection[i]))
                {
                    intersection.RemoveAt(i);
                }
            }
            return intersection;

        }

        static void PrintList(List<int> list)
        {
            Console.Write("{ ");
            foreach(var item in list)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("}");
        }
        static void Main(string[] args)
        {
            List<int> primes = GetPrimes(2, 30);
            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write("{0} ", primes[i]);
            }
            //foreach (var item in primes)
            //{
            //    Console.Write("{0} ", item);
            //}
            Console.WriteLine("\n");

            List<int> listOne = new List<int>();
            listOne.Add(3);
            listOne.Add(6);
            listOne.Add(2);
            listOne.Add(7);
            listOne.Add(4);
            listOne.Add(5);

            List<int> listTwo = new List<int>();
            listTwo.Add(2);
            listTwo.Add(3);
            listTwo.Add(8);
            listTwo.Add(5);
            listTwo.Add(4);
            listTwo.Add(1);

            
            PrintList(listOne);
            PrintList(listTwo);
            List<int> unionList = Union(listOne, listTwo);
            PrintList(unionList);
            Console.WriteLine("\n");
            PrintList(listOne);
            PrintList(listTwo);
            List<int> intersectionList = Intersect(listOne, listTwo);
            PrintList(intersectionList);
            
            Console.ReadLine();

        }
    }
}
