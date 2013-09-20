using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 变量交换
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 123;
            int num2 = 456;
            int temp;
            Console.WriteLine("变量交换值前：num1={0},num2={1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("变量交换值后：num1={0},num2={1}", num1, num2);
            Console.ReadKey();

        }
    }
}
