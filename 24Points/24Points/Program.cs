using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Points
{
    class Program
    {
        
        static int count;
        static void Main(string[] args)
        {
        }

        public static bool TryAllSigns(int[] input,string sequence, int currentNum)
        {
            if (count == 3 && currentNum == 24)
            {
                return true;
            }
            else if (count == 3 && currentNum != 24)
            {
                count--;
                return false;
            }
            count++;
            if (TryAllSigns(input, sequence, currentNum + input[count]))
            {
                return true;
            }
            else if(TryAllSigns(input, sequence, currentNum - input[count])){
                return true;
            }
            else if (TryAllSigns(input, sequence, currentNum * input[count])){
                return true;
            }
            else if (TryAllSigns(input, sequence, currentNum / input[count])){
                return true;
            }

            return false;
            
        }
    }
}
