using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 500)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}



            Console.WriteLine("你们班有多少人：");
            int count = Convert.ToInt32(Console.ReadLine());
            int score = 0;
            int sum = 0;
            int i=0;
            while( i<count)
            {
                Console.WriteLine("请输入第{0}个学生的成绩：",i+1);
                score = Convert.ToInt32(Console.ReadLine());
                sum=sum+score;
                i++;

            }
            Console.WriteLine(" {0}个人，共{1}分，平均分是{2}",count,sum,sum/count);
            Console.ReadKey();
        }
    }
}
