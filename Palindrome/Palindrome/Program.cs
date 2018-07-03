using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPalindrome2(100030001))
            {
                Console.WriteLine("hi");
            }
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else if (x == 0)
            {
                return true;
            }
            string stringX = x.ToString();
            if (stringX.Length == 1)
            {
                return true;
            }
            if (stringX.Length == 2)
            {
                if (stringX[0] == stringX[1])
                {
                    return true;
                }
                return false;
            }
            if (stringX.Length == 3)
            {
                if (stringX[0] != stringX[2])
                {
                    return false;
                }
            }
            for (int i = 0; i < stringX.Length / 2; i++)
            {
                if (stringX[i] != stringX[stringX.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;


        }
        public static bool IsPalindrome2(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int x2 = x;
            int back = 0;
            while (x != 0)
            {
                back *= 10;
                back += x % 10;                 
                x = x / 10;
            }
            return (back == x2);
        }
    }
                
           
}
