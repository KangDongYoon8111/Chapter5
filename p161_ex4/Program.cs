using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            string input = Console.ReadLine();
            string season="";

            switch (input)
            {
                case "3": case "4": case "5":
                    season = "봄";
                    break;
                case "6": case "7": case "8":
                    season = "여름";
                    break;
                case "9": case "10": case "11":
                    season = "가을";
                    break;
                case "12": case "1": case "2":
                    season = "겨울";
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                    break;
            }

            Console.WriteLine($"입력하신 {input}월은 {season} 입니다.");
        }
    }
}
