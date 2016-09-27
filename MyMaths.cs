namespace FibonacciWithMyMathsClass
{
    public class MyMaths
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}