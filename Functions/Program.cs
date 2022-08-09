using System;

namespace Functions
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+' , '/' , '*' või '-')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SeparateTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;





            }

        }

        private static void AddTwoNumbers(object userNumberOne, int userNumberTwo)
        {
            throw new NotImplementedException();
        }

        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        public static void MultiplyTwoNumbers(double x, double y)
        { 
            double result = x * y;
            Console.WriteLine(result);
        }

        public static void SeparateTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }
    }
}
