﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number % 3 == 0)
            {
                Console.WriteLine($"입력하신 정수 {number}은(는) 3의 배수 입니다.");
            }
            else
            {
                Console.WriteLine($"입력하신 정수 {number}은(는) 3의 배수가 아닙니다.");
            }
        }
    }
}
