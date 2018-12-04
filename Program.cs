using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {


        public int a;
        public int b;
        public int op;



        public static double add(int a, int b)
        {

            return a + b;
        }
        public static double sub(int a, int b)
        {

            return a - b;
        }

        public static double mult(int a, int b)
        {
            return a * b;
        }
        public static double div(int a, int b)

        {
            return a / b;
        }


    }










}




namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new Class1();



            Console.WriteLine("plesea inter type of op");
            Console.WriteLine("**********************");
            Console.WriteLine("1.additi");
            Console.WriteLine("2.substaract");
            Console.WriteLine("3.multi");
            Console.WriteLine("4.div");

            cal.op = Convert.ToInt32(Console.ReadLine());

            if (cal.op == 1)
            {
                Console.WriteLine("plesea inter first number ");
                cal.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("plesea inter second number ");
                cal.b = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("sum of{0} and{1} is {2}", cal.a, cal.b, Class1.add(cal.a, cal.b));
                Console.ReadLine();


            }

            else if (cal.op == 2)
            {
                Console.WriteLine("plesea inter first number ");
                cal.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("plesea inter second number ");
                cal.b = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("product  of{0} and{1} is {2}", cal.a, cal.b, Class1.sub(cal.a, cal.b));
                Console.ReadLine();




            }

            else if (cal.op == 3)
            {
                Console.WriteLine("plesea inter first number ");
                cal.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("plesea inter second number ");
                cal.b = Convert.ToInt32(Console.ReadLine());
                if (cal.b != 0)
                {
                    Console.WriteLine("product  of{0} and{1} is {2}", cal.a, cal.b, Class1.mult(cal.a, cal.b));
                    Console.ReadLine();

                }



                else { Console.WriteLine(" second number must be different to zero"); }

               
                









            }



            else if (cal.op == 4)
            {
                Console.WriteLine("plesea inter first number ");
                cal.a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("plesea inter second number ");
                cal.b = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("product  of{0} and{1} is {2}", cal.a, cal.b, Class1.div(cal.a, cal.b));
                Console.ReadLine();


            }

            else Console.WriteLine("invalid op");




        }
    }
}




