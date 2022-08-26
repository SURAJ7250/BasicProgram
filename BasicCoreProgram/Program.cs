using System;
namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.flip coin\n 2.leap year\n 3.Power of 2");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.Coin();
                    break;
                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.Year();
                    break;
                case 3:
                    Console.WriteLine("3. Power Of 2 ");
                    PowerOfTwo power = new PowerOfTwo();
                    power.Read();
                    break;
                default:
                    break;
            }
        }
    }
}
