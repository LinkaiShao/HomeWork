using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Hex_Calculator
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var testString = "1.5 + 2.4 - 3.2 * 2.67895 / 3.56";
            var numbers = testString.Split('+', '-', '*', '/');
            var signs = new char[numbers.Length-1];
            var start = 0;
            for (var i = 0; i < signs.Length; i++)
            {
                var signPostion = start + numbers[i].Length;
                signs[i] = testString[signPostion];
                start = signPostion + 1;
            }
            return;
            Console.WriteLine(Calculator("1.5 + 2.4-3.2*2.67895/3.56"));
            Console.ReadLine();
        }
        public static double StringToDouble(string input)
        {
            double result=0;
            if(double.TryParse(input, out result))
            {
                return result;
            }
            return -1.0;
        }

        public static int HexConverter (string hex)
        {
            return Convert.ToInt32(hex, 16);
        }
        

        public static string RemoveSpace (string input)
        {
            input = input.Replace(" ", "");
            return input;
        }

        public static List<char> IdentifySigns (string input)
        {
            char[] charArray=input.ToCharArray();
            List<char> signList = new List<char>();
            for(int i = 0; i < input.Length; i++)
            {
                if (charArray[i] == '+' || charArray[i] == '-' || charArray[i] == '*' || charArray[i] == '/')
                {
                    signList.Add(input[i]);
                }
            }
            return signList;
        }

        public static List<double> IdentifyAllDoubles (string input)
        {
            char[] charArray = input.ToCharArray();
            List<int> signLocations = new List<int>();
            List<double> result = new List<double>();
            for(int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '+' || charArray[i] == '-' || charArray[i] == '*' || charArray[i] == '/')
                {
                    signLocations.Add(i);
                }
            }
            result.Add(double.Parse(input.Substring(0, signLocations[0])));
            for(int i = 0; i < signLocations.Count-1; i++)
            {
                result.Add(double.Parse(input.Substring(signLocations[i]+1, (signLocations[i + 1]- (signLocations[i] + 1)))));
            }
             result.Add(double.Parse(input.Substring(signLocations[signLocations.Count-1]+1, (input.Length - signLocations[signLocations.Count-1]-1))));
            return result;
        }

        public static double Calculator(string input)
        {
            input = RemoveSpace(input);
            List<char> allSigns = IdentifySigns(input);
            List<double> allNumbers = IdentifyAllDoubles(input);
            int currentSign = 0;
            while (allSigns.Contains('*') || allSigns.Contains('/'))
            {
                for (int i = 0; i < allSigns.Count; i++)
                {
                    if (allSigns[i] == '*' || allSigns[i] == '/')
                    {
                        currentSign = i;
                        i = allSigns.Count;
                    }
                }
                if (allSigns[currentSign] == '*')
                {
                    allNumbers[currentSign] = allNumbers[currentSign] * allNumbers[currentSign + 1];
                    allNumbers.RemoveAt(currentSign + 1);
                    allSigns.RemoveAt(currentSign);
                }
                else if (allSigns[currentSign] == '/')
                {
                    allNumbers[currentSign] = allNumbers[currentSign] / allNumbers[currentSign + 1];
                    allNumbers.RemoveAt(currentSign + 1);
                    allSigns.RemoveAt(currentSign);
                }
            }
            while (allSigns.Contains('+') || allSigns.Contains('-'))
            {
                for (int i = 0; i < allSigns.Count; i++)
                {
                    if (allSigns[i] == '+' || allSigns[i] == '-')
                    {
                        currentSign = i;
                        i = allSigns.Count;
                    }
                }
                if (allSigns[currentSign] == '+')
                {
                    allNumbers[currentSign] = allNumbers[currentSign] + allNumbers[currentSign + 1];
                    allNumbers.RemoveAt(currentSign + 1);
                    allSigns.RemoveAt(currentSign);
                }
                else if (allSigns[currentSign] == '-')
                {
                    allNumbers[currentSign] = allNumbers[currentSign] - allNumbers[currentSign + 1];
                    allNumbers.RemoveAt(currentSign + 1);
                    allSigns.RemoveAt(currentSign);
                }
            }
            return allNumbers[0];


        }
    }
}
