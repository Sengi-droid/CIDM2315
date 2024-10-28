using System;

class Homework8
{
    static void Main(string[] args)
    {
        // Create Customer objects and customer_list
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call Q1 method
        TotalCredits(customer_list);
        // Call Q2 method
        AmarilloAverageAge(customer_list);
        // Call Q3 method
        CanyonAge(customer_list);
    }

    // Q1: Calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0;

        foreach (var customer in customer_list)
        {
            totalCredit += customer.customerCredit;
        }

        Console.WriteLine($"Total Credit: {totalCredit}");
    }

    // Q2: Calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        int totalAge = 0;
        int count = 0;

        foreach (var customer in customer_list)
        {
            if (customer.customerCity == "Amarillo")
            {
                totalAge += customer.customerAge;
                count++;
            }
        }

        double averageAge = (count > 0) ? (double)totalAge / count : 0;
        Console.WriteLine($"Average Age in Amarillo: {averageAge}");
    }

    // Q3: Print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.WriteLine("Customers in Canyon older than 30:");

        foreach (var customer in customer_list)
        {
            if (customer.customerCity == "Canyon" && customer.customerAge > 30)
            {
                Console.WriteLine(customer.customerName);
            }
        }
    }
}

// Q4: Create a class called Customer
class Customer
{
    public string customerName { get; }
    public int customerAge { get; }
    public string customerCity { get; }
    public double customerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}
