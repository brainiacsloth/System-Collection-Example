using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Creating a list using ArrayList (non-generic)
        IList myList = new ArrayList();

        // Adding elements
        myList.Add("Apple");
        myList.Add("Banana");
        myList.Add("Orange");

        // Accessing elements using the indexer property
        Console.WriteLine("Element at index 0: " + myList[0]);
        Console.WriteLine("Element at index 1: " + myList[1]);
        Console.WriteLine("Element at index 2: " + myList[2]);
    }
}
