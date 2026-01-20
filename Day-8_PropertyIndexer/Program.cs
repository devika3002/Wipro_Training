using System;

//
// Employee class 
// Properties -Identity details
// Indexer - Monthly attendance
//
class Employee
{
    // Property to store Employee ID
    public int EmployeeId { get; set; }

    // Property to store Employee Name
    public string EmployeeName { get; set; }

    // Array to store attendance for 12 months
    private int[] attendance = new int[12];

    // Indexer to access monthly attendance using index

    public int this[int month]
    {
        get
        {
            return attendance[month];
        }
        set
        {
            attendance[month] = value;
        }
    }
}

//
// Product class 
// Properties - Product details
// Indexer - Customer ratings
//
class Product
{
    // Property to store Product Name
    public string ProductName { get; set; }

    // Property to store Product Price
    public double Price { get; set; }

    // Array to store ratings given by customers
    private int[] ratings = new int[5];

    // Indexer to access customer ratings using index
    
    public int this[int customerIndex]
    {
        get
        {
            return ratings[customerIndex];
        }
        set
        {
            ratings[customerIndex] = value;
        }
    }
}

// Main class

class Program
{
    static void Main()
    {
        //  Employee Case 

        // Creating Employee object
        Employee emp = new Employee();

        // Setting values using properties
        emp.EmployeeId = 101;
        emp.EmployeeName = "Divya";

        // Setting monthly attendance using indexer
        emp[0] = 22; // January attendance
        emp[1] = 20; // February attendance

        // Displaying employee details
        Console.WriteLine("Employee Management");
        Console.WriteLine("Employee ID: " + emp.EmployeeId);
        Console.WriteLine("Employee Name: " + emp.EmployeeName);
        Console.WriteLine("January Attendance: " + emp[0]);
        Console.WriteLine("February Attendance: " + emp[1]);

        // E-Commerce Case

        // Creating Product object
        Product product = new Product();

        // Setting product details using properties
        product.ProductName = "Laptop";
        product.Price = 55000;

        // Setting customer ratings using indexer
        product[0] = 5; // Rating from customer 1
        product[1] = 4; // Rating from customer 2

        // Displaying product details
        Console.WriteLine("\nE-Commerce");
        Console.WriteLine("Product Name: " + product.ProductName);
        Console.WriteLine("Price: " + product.Price);
        Console.WriteLine("Customer 1 Rating: " + product[0]);
        Console.WriteLine("Customer 2 Rating: " + product[1]);
    }
}
