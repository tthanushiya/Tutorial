﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_12_Foreach_Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5]; // declaring array

            //Storing value in array element
            arr[0] = "Steven";
            arr[1] = "Clark";
            arr[2] = "Mark";
            arr[3] = "Thompson";
            arr[4] = "John";

            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadLine();
        }
    }
}
