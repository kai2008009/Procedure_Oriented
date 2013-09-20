using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            //验证密码
            //Console.WriteLine("请输入密码：");
            //int psword = Convert.ToInt32(Console.ReadLine());
            //if (psword == 888888)
            //{
            //    Console.WriteLine("密码正确");
            //}
            //else
            //{
            //    Console.WriteLine("密码bu正确,请再次输入：");
            //    int psword1 = Convert.ToInt32(Console.ReadLine());
            //    if (psword1 == 888888)
            //    {
            //        Console.WriteLine("密码正确");
            //    }
            //}



            //验证登录
            //Console.WriteLine("请输入用户名：");
            //string name = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("请输入密码：");
            //int psw = Convert.ToInt32(Console.ReadLine());

            //if (name == "admin" && psw == 888888)
            //{
            //    Console.WriteLine("登录成功！");
            //}
            //else if (name != "admin") 
            //{
            //    Console.WriteLine("用户名不存在！");
            //}
            //else if(name=="admin")
            //{
            //    Console.WriteLine("密码错误！");
            //}



            //验证年龄
            //Console.WriteLine("请输入你的年龄：");
            //int age=Convert.ToInt32( Console.ReadLine());

            //if (age > 18)
            //{
            //    Console.WriteLine("可以收看！");
            //}
            //else if (age >= 10)
            //{
            //    Console.WriteLine("是否收看，y/n");
            //    char es = Convert.ToChar(Console.ReadLine());
            //    if (es == 'y')
            //    {
            //        Console.WriteLine("继续收看！");
            //    }
            //    else
            //    {
            //        Console.WriteLine("停止收看");
            //    }
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("不能收看！");
            //}




            //工资评定
            //Console.WriteLine("李四的年终工作评定，请输入：");
            //string input = Console.ReadLine();
            //decimal ses = 5000;
            //bool a = false;
            //switch (input)
            //{
            //    case "A":
            //        ses += 500;
            //        break;
            //    case "B":
            //        ses += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":
            //        ses -= 200;
            //        break;
            //    case "E":
            //        ses -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("你输入的字符有问题");
            //        a = true;
            //        break;
            //}
            //if (a == false)
            //{
            //    Console.WriteLine("{0}", ses);
            //}



            //分数等级
            //Console.WriteLine("输入分数：");
            //int num =Convert.ToInt32( Console.ReadLine());

            //switch (num / 10)
            //{
            //    case 9:
            //        Console.WriteLine("A级");
            //        break;
            //    case 8:
            //        Console.WriteLine("B级");
            //        break;
            //    case 7:
            //        Console.WriteLine("C级");
            //        break;
            //    case 6:
            //        Console.WriteLine("D级");
            //        break;
            //    default:
            //        break;
            //}




            //使用if语句
            Console.WriteLine("请输入您的手机名字：");
            string name = Console.ReadLine();

            if (name == "mx2")
            {
                Console.WriteLine("哇，你的{0}手机好漂亮！", name);
            }
            else if (name == "ip5")
            {
                Console.WriteLine("我靠，是糕富帅啊！");
            }
            else
            {
                Console.WriteLine("你tmd,{0}是什么破手机", name);
            }
            Console.ReadKey();
        }
    }
}
