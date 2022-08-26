using System;
namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program\n 1.flip coin\n 2.leap year\n 3.Power of 2\n 4.Odd And Even\n 5.Largest Number\n 6.Harmonic Numbers\n 7.Factors");
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
                case 4:
                    OddEven oddeve = new OddEven();
                    oddeve.Read();
                    break;
                case 5:
                    LargestNum num = new LargestNum();
                    num.Read();
                    break;
                case 6:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.Number();
                    break;
                case 7:
                    Factors factors = new Factors();
                    factors.Fact();
                    break;
                default:
                    Console.WriteLine("Select correct option");
                    break;
            }
        }
    }
}
