using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.if_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(6, 8));
            //freeze

            Console.ReadLine();

        }
        static int GetMax(int num1, int num2)
        {


            if (num1 > num2)
            {
                Console.Write("the max is ");
                return num1;
            }
            else
            {
                Console.Write("the max is ");
                return num2;
            }
        }
        }
}
