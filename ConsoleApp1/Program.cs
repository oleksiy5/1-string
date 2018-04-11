using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = String.Empty;
            while(inputValue != "end")
            {
                inputValue = Console.ReadLine();
                if (!string.IsNullOrEmpty(inputValue))
                {
                    char[] charArr = inputValue.ToCharArray();
                    Array.Reverse(charArr);
                    StringBuilder sb = new StringBuilder();
                    for(int i = 0; i < charArr.Length;i++)
                    {
                        if (i == 0)
                            Console.Write(charArr[i].ToString().ToUpper());
                        else
                            Console.Write(charArr[i].ToString().ToLower());
                    }
                }
                else
                {
                    Console.WriteLine("Pleas give your name.");
                }
            }
        }
    }
}
