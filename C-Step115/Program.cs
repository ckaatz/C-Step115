using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step115
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass NewClass = new MathClass();
            Console.WriteLine("Pick a number:");
            int UserInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("True/False: do you want to pick a second number?");
            bool SecondNumber = Convert.ToBoolean(Console.ReadLine());
            if (SecondNumber)
            {
                Console.WriteLine("Pick a second number:");
                int UserInput2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(NewClass.MathOperation(UserInput1, UserInput2));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(NewClass.MathOperation(UserInput1));
                Console.ReadLine();
            }
        }
    }

    public class MathClass
    {
        public int MathOperation(int Num1, int Num2 = 1)
        {
            return Num1 * Num2;
        }
    }
}
