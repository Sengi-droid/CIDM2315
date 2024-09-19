namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Q1_method();

            Q2_method();
        }

        static void Q1_method()
        {
            Console.WriteLine("Q1: Finding the largest number.");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int largest = GetLargest(num1, num2);
            Console.WriteLine($"The largest number is: {largest}");
        }

        static int GetLargest(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Q2_method()
        {
            Console.WriteLine("\nQ2: Printing triangles based on shape.");

            Console.Write("Enter an integer N: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter the shape (left/right): ");
            string shape = Console.ReadLine().ToLower();

            if (shape == "left")
            {
                Console.WriteLine($"N = {N}, Shape = {shape}");
                PrintLeftTriangle(N);
            }
            else if (shape == "right")
            {
                Console.WriteLine($"N = {N}, Shape = {shape}");
                PrintRightTriangle(N);
            }
            else
            {
                Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");
            }
        }

        static void PrintLeftTriangle(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintRightTriangle(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

