using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int resule = Test(out number);
            Console.WriteLine("{0}     {1}", number, resule);


            Console.ReadKey();

        }
        public static int Test(out int a)
        {
            a = 20;
            return a;
        }
    }
}
