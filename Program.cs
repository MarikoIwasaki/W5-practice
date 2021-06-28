using System;

namespace W5_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int number1 = 1;
            int number2 = 2;

            int add = p.AddNumbers();
            int sub = p.SubNumbers(number1, number2);
            int div = p.DivNumbers(number1, number2);
            int mul = p.MulNumbers(number1, number2);

            Console.WriteLine("The results of Addition/Subtraction/Division/Multiplication Operations are" + add + "," + sub + "," + div + "," + mul);

            p.checkNumber(div);
            p.checkNumber(mul);

            Console.WriteLine("end of operation");
            Console.ReadKey();
        }
        public int AddNumbers()
        {
            Console.WriteLine("enter a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res = a + b;
            Console.WriteLine("The addition is:" + res);
            return res;
        }
        public int SubNumbers(int n1, int n2)
        {
            Console.WriteLine("Number one is" + n1);
            Console.WriteLine("Number two is:" + n2);
            int res = n2 - n1;
            Console.WriteLine("The subtraction is:" + res);
            return res;
        }
        public int DivNumbers(int n1, int n2)
        {
            Console.WriteLine("Number one is" + n1);
            Console.WriteLine("Number two is:" + n2);
            int res = n1 / n2;
            Console.WriteLine("The division is:" + res);
            return res;
        }
        public int MulNumbers(int n1, int n2)
        {
            Console.WriteLine("Number one is" + n1);
            Console.WriteLine("Number two is:" + n2);
            int res = n1 * n2;
            Console.WriteLine("The multiplication is:" + res);
            return res;
        }
        public void checkNumber(int n)
        {
            if(n>=0)
            {
                Console.WriteLine("The number is Positive number");
            }
            else
            {
                Console.WriteLine("The number is Negative Number");
            }
        }
    }
}
