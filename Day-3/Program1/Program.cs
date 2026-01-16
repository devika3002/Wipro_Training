using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Abstractclass;
        
        
        
Console.WriteLine("Hello, World!");

ElectronicProduct newobject = new ElectronicProduct();
newobject.ProductID = 101;
newobject.ProductName = "Laptop";
newobject.DisplayProductNameDetails();
newobject.ShowElectronicProductDetails();

IDiscountTable discountTable1 = newobject;
double discount = discountTable1.CalculateDiscount(50000);
Console.WriteLine("Discount on Electronic Product: " + discount);

       

        // Furniture Product object
FurnitureProduct furniture = new FurnitureProduct();
furniture.ProductID = 201;
furniture.ProductName = "Chair";
furniture.DisplayProductNameDetails();
furniture.ShowFurnitureProductDetails();

double furnitureDiscount = furniture.CalculateDiscount(20000);
Console.WriteLine("Discount on Furniture Product: " + furnitureDiscount);

class ElectronicProduct : Product
{
    public override void DisplayProductNameDetails()
    {
        Console.WriteLine("Electronic Product Name: " + ProductName);
        Console.WriteLine("Electronic Product ID: " + ProductID);
    }

    public void ShowElectronicProductDetails()
    {
        Console.WriteLine("this is an electronic product from child class");
    }

    public override double CalculateDiscount(double price)
    {
        double discountRate = 0.15;
        return price * discountRate;
    }
}

class FurnitureProduct : Product
{
    public override void DisplayProductNameDetails()
    {
        Console.WriteLine("Furniture Product Name: " + ProductName);
        Console.WriteLine("Furniture Product ID: " + ProductID);
    }

    public void ShowFurnitureProductDetails()
    {
        Console.WriteLine("this is a furniture product from child class");
    }

    public override double CalculateDiscount(double price)
    {
        double discountRate = 0.15;
        return price * discountRate;
    }
}
