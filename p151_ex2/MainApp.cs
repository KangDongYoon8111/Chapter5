using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            string grade;
            if (number >= 90)
            {
                grade = "A";
            }
            else if (number >= 80)
            {
                grade = "B";
            }
            else if (number >= 70)
            {
                grade = "C";
            }
            else
            {
                grade = "F";
            }

            Console.WriteLine($"입력하신 점수 {number}는(은) " +
                $"{grade} 학점 입니다.");
        }
    }
}
