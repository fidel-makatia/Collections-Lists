using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(10){10, 10, 11};
            List<int> otherList = new List<int>() { 1000, 30, 56 };


            //add method

            myList.Add(400);

            //add range method

            myList.AddRange(otherList);

            //insert

            myList.Insert(1, 20);

            //insert range

           myList.InsertRange(3, otherList);




            //Remove
            myList.Remove(10);

            //Remove AT an index
            int ind = 0;
            if (ind < myList.Count)
            {
                myList.RemoveAt(ind);
            }
            //read Elements
            Console.WriteLine("Before remove range");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Remove range

            myList.RemoveRange(0, 3);

            //remove all
            myList.RemoveAll(n => n >= 60);// using lamda expression


            //read Elements
            Console.WriteLine("After remove range");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
