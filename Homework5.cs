namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method
            int largestQ1 = Q1_method();
            Console.WriteLine($"The largest number from Q1 is: {largestQ1}");

            // Call Q2_method
            int largestQ2 = Q2_method();
            Console.WriteLine($"The largest number from Q2 is: {largestQ2}");

            // Call Q3_method
            Q3_method();
        }

        // Q1_method
        static int Q1_method()
        {
            Console.WriteLine("Enter first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return Math.Max(num1, num2);
        }

        // Q2_method
        static int Q2_method()
        {
            Console.WriteLine("Enter first integer:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third integer:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourth integer:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            // Use Q1_method to find the largest numbers
            int max1 = Q1_method(num1, num2);
            int max2 = Q1_method(num3, num4);
            return Math.Max(max1, max2);
        }

        static int Q1_method(int a, int b)
        {
            return Math.Max(a, b);
        }

        // Q3_method
        static void Q3_method()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("Re-enter password:");
            string confirmPassword = Console.ReadLine();

            Console.WriteLine("Enter birth year:");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password == confirmPassword)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }

        static bool checkAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age >= 18;
        }
    }
}

