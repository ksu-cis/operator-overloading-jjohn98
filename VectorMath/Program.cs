using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");

            Console.WriteLine($"Object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator: {one + two}");

            Console.WriteLine($"Subtraction Operator: {one - two}");

            Console.WriteLine($"Scalar Operator: {one * 5}");

            Console.WriteLine($"Comparison Operator: {one == two}");
        }
    }
}
