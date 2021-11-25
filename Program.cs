using System;
using System.Collections.Generic;

namespace EXCERCISE_ARP_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PENALTYVALUE = 2500;
            
            Console.WriteLine("Taller ARP 5");
            List<int> list_number = new List<int>();

            list_number.Add(1);
            list_number.Add(2);
            list_number.Add(3);
            list_number.Add(4);
            Console.WriteLine("hay: " + list_number.Count);
            foreach(var item in list_number){
                Console.WriteLine("old list: " + item);
            }

            int x = list_number[0];
            Console.WriteLine(x);
            list_number.RemoveAt(0);

            foreach (var item in list_number)
            {
                Console.WriteLine("new list: " + item);
            }

            Console.WriteLine(list_number.Equals(null));
            list_number.Clear();
            Console.WriteLine(list_number.Count);
        }
    }
}
