using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Points2
{
    public class Program
    {
    
        static void Main(string[] args)
        {
            Dictionary<string, char[]> AllSolutions = new Dictionary<string, char[]>();
            AllSolutions = GetAllCombos();
        }
        public static Dictionary<string,char[]> GetAllCombos()
        {
            Dictionary<string, char[]> dict = new Dictionary<string, char[]>();
            int endNum = 0;
            List<int> nums = new List<int>();
            List<char> signs = new List<char>();
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    for(int k = 1; k < 10; k++)
                    {
                        for(int l = 1; l < 10; l++)
                        {
                            for(int m = 0; m < 3; m++)
                            {
                                for(int n = 0; n < 3; n++)
                                {
                                    for(int o = 0; o < 3; o++)
                                    {
                                        if (Math(Math(Math(i, j, m), k, n), l, o) == 24)
                                        {
                                            nums.Add(i);
                                            nums.Add(j);
                                            nums.Add(k);
                                            nums.Add(l);
                                            signs.Add(SignIdentify(m));
                                            signs.Add(SignIdentify(n));
                                            signs.Add(SignIdentify(o));
                                            if(!dict.ContainsKey((nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString())) {
                                                dict.Add((nums[0] * 1000 + nums[1] * 100 + nums[2] * 10 + nums[3]).ToString(), signs.ToArray());
                                            }
                                            
                                            nums.Clear();
                                            signs.Clear();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            return dict;
        }
        public static int Math(int num1, int num2, int sign)
        {
            if (sign == 0)
            {
                return num1 + num2;
            }
            else if (sign == 1)
            {
                return num1 - num2;
            }
            else if (sign == 2)
            {
                return num1 * num2;
            }
            else if (sign == 3)
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }
        public static int IdentifySign(char sign)
        {
            if (sign == '+')
            {
                return 0;
            }
            else if (sign == '-')
            {
                return 1;
            }
            else if (sign == '*')
            {
                return 2;
            }
            else
            {
                return 3;
            }

        }
        public static char SignIdentify(int sign)
        {
            if (sign == 0)
            {
                return '+';
            }
            else if (sign == 1)
            {
                return '-';
            }
            else if(sign == 2)
            {
                return '*';
            }
            else
            {
                return '/';
            }

        }

    }
}
