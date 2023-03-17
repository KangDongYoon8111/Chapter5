using System;

namespace Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if(answer == "아니오")
                {
                    return;
                }
            }
            Console.WriteLine("여기는 Main메서드입니다.");
        }
    }
}
