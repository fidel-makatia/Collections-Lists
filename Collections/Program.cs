using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>(){10, 10, 11};

            //read Elements

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
