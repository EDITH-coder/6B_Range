using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6B_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(areInRange(11, 20, 12));
            Console.WriteLine(areInRange(30, 30, 17));
            Console.WriteLine(areInRange(25, 35, 50));
            Console.WriteLine(areInRange(15, 12, 8));
            Console.ReadLine();
        }
        //Method to check whether three given integer values are in the range 20..50 inclusive.
        //Return true if 1 or more of them are in the said range otherwise false.
        public static bool areInRange( int num1,int num2,int num3)
        {
            if(num1>=20 && num1 <= 50 || num2>=20 && num2 <=50 || num3>=20 && num3<=50)
            {
                return true;
            }
            return false;

        }
    }
}
