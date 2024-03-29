﻿using System;

namespace Switch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요." +
                "(ex. 일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();

            float a = 1.3f;
            switch (day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    if(a >= 0)
                    {
                        Console.WriteLine("2Tuesday");
                    }
                    else
                    {
                        Console.WriteLine("1Tuesday");
                    }                    
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
    }
}
