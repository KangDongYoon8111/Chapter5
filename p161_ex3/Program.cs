using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("몇월이 궁금하세요? : ");
                string input = Console.ReadLine();
                int day = 0;

                switch (input)
                {
                    case "1":
                    case "3":
                    case "5":
                    case "7":
                    case "8":
                    case "10":
                    case "12":
                        day = 31;
                        break;
                    case "4":
                    case "6":
                    case "9":
                    case "11":
                        day = 30;
                        break;
                    case "2":
                        day = 28;
                        break;
                    default:
                        Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                        //break;
                        return;
                }

                Console.WriteLine($"{input}월은 {day}일까지 있습니다.");
            }
            //Console.Write("몇월이 궁금하세요? : ");
            //string input = Console.ReadLine();
            //int day = 0;

            //switch (input)
            //{
            //    case "1": case "3": case "5": 
            //    case "7": case "8": case "10": case "12":
            //        day = 31;
            //        break;
            //    case "4": case "6": case "9": case "11":
            //        day = 30;
            //        break;
            //    case "2":
            //        day = 28;
            //        break;
            //    default:
            //        Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
            //        //break;
            //        return;
            //}

            //Console.WriteLine($"{input}월은 {day}일까지 있습니다.");
        }
    }
}
