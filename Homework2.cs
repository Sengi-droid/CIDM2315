namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1
            Console.WriteLine("Enter a letter grade (A, B, C, D, F):");
            string grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("GPA Points: 4");
                    break;
                case "B":
                    Console.WriteLine("GPA Points: 3");
                    break;
                case "C":
                    Console.WriteLine("GPA Points: 2");
                    break;
                case "D":
                    Console.WriteLine("GPA Points: 1");
                    break;
                case "F":
                    Console.WriteLine("GPA Points: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }

            Console.WriteLine(); 

            // Code for Q2
            Console.WriteLine("Enter three numbers to find the smallest value:");
            
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine($"The smallest value is: {smallest}");
        }
    }
}
