﻿using System;

namespace While2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            //do
            //{
            //    Console.WriteLine("a) i : {0}", i--);
            //}
            //while (i > 0);

            while (i > 0)
            {
                Console.WriteLine("a) i : {0}", i--);
            }

            do
            {
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);

            //while (i > 0)
            //{
            //    Console.WriteLine("a) i : {0}", i--);
            //}

            //while (i > 0)
            //{
            //    Console.WriteLine("b) i : {0}", i--);
            //}
        }
    }
}
