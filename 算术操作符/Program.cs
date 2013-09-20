using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算术操作符
{
    class Program
    {
        enum Weekday
        {
            sunday, Monday, Tuesday, wednesday, Thursday, Friday, Saturday
        };

        static void Main(string[] args)
        {
            string mystr1 = "你好";
            string mystr2 = "刘阿哥";
            string mystr3 = mystr1 + mystr2;
            Weekday d1 = Weekday.sunday;
            Weekday d2 = d1 + 3;
            Console.WriteLine("d1={0},d2={1}", d1, d2);
            Console.WriteLine(mystr3);
            Console.ReadKey();
        }
    }
}
