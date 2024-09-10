namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double X = 2.5;
            double Y = 3.3;

            double Z = 4 * X * X + 3 * Y;
            //Results
            Console.WriteLine($"x = {X}, y = {Y} The value of Z is {Z:F1}");
        }
    }
}
