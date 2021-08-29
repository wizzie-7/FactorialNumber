using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            FactOfNumber FN = new FactOfNumber();
            FN.AcceptInput();
            FN.CalcFactorial();
        }

    }
    public class FactOfNumber
    {
        int n, i;
        int res = 1;
        public void AcceptInput()
        {
            Console.WriteLine("Enter the Number :");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void CalcFactorial()
        {
            for(i=1;i<=n;i++)
            {
                res *= i;
                
            }
            Console.Write("The factorial of "+n+ " is "+res);
        }
    }
}
