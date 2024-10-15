namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Answer Q1: Creating Professor objects
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);
            
            // Answer Q1: Creating Student objects
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);
            
            // Answer Q2: Printing Professor details
            Console.WriteLine("Professor Details:");
            Console.WriteLine($"Name: {professor1.ProfName}, Class: {professor1.ClassTeach}, Salary: {professor1.GetSalary()}");
            Console.WriteLine($"Name: {professor2.ProfName}, Class: {professor2.ClassTeach}, Salary: {professor2.GetSalary()}");
            
            // Calculate and print the difference in salary
            double salaryDifference = professor1.GetSalary() - professor2.GetSalary();
            Console.WriteLine($"Salary Difference: {salaryDifference}");
            
            // Answer Q2: Printing Student details
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {student1.StudentName}, Class: {student1.ClassEnroll}, Grade: {student1.GetGrade()}");
            Console.WriteLine($"Name: {student2.StudentName}, Class: {student2.ClassEnroll}, Grade: {student2.GetGrade()}");
            
            // Calculate and print the total grade
            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"Total Grade: {totalGrade}");
        }
    }

    class Professor
    {
        // Private attributes
        private string profName;
        private string classTeach;
        private double salary;

        // Constructor
        public Professor(string name, string subject, double salaryAmount)
        {
            profName = name;
            classTeach = subject;
            SetSalary(salaryAmount);
        }

        // Method to set salary
        public void SetSalary(double salaryAmount)
        {
            salary = salaryAmount;
        }

        // Method to get salary
        public double GetSalary()
        {
            return salary;
        }

        // Properties for professor's name and class taught
        public string ProfName => profName;
        public string ClassTeach => classTeach;
    }

    class Student
    {
        // Private attributes
        private string studentName;
        private string classEnroll;
        private double studentGrade;

        // Constructor
        public Student(string name, string course, double grade)
        {
            studentName = name;
            classEnroll = course;
            SetGrade(grade);
        }

        // Method to set grade
        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        // Method to get grade
        public double GetGrade()
        {
            return studentGrade;
        }

        // Properties for student's name and class enrolled
        public string StudentName => studentName;
        public string ClassEnroll => classEnroll;
    }
}
