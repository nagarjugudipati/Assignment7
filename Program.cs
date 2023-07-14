using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            // Add elements to the ArrayList
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("elderberry");

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements: " + arrayList.Count+"\n");
            Console.WriteLine("They are :");
            foreach (object element in arrayList)
            {

                Console.WriteLine(element);
            }
            Console.WriteLine("\n");
            // Check if the ArrayList contains the element "date"
            bool containsDate = arrayList.Contains("date");
            Console.WriteLine("ArrayList contains 'date': " + containsDate+"\n");

            // Insert the element "fig" at the second position in the ArrayList
            arrayList.Insert(1, "fig");
            Console.WriteLine("After adding fig");
            foreach (object element in arrayList)
            {
               
                Console.WriteLine(element);
            }
            Console.WriteLine("\n");
            // Remove the element "banana" from the ArrayList
            arrayList.Remove("banana");
            Console.WriteLine("After Removing banana");
            foreach (object element in arrayList)
            {

                Console.WriteLine(element);
            }
            Console.WriteLine("\n");
            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (object element in arrayList)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
    

