using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            ////类型转换TryParse
            //string s = "123a";
            //int re;

            //if (int.TryParse(s, out re) == true)
            //{
            //    Console.WriteLine("转换成功");
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            string s = "123q";
            int re;
            if (IntTryParse(s, out re))
            {
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            Console.ReadKey();

            Console.ReadKey();
        }
        static bool IntTryParse(string s, out int resule)
        {
                resule = 0;
            try
            {
                resule = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
