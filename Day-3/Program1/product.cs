using System;

namespace Abstractclass
{
    public abstract class Product : IDiscountTable
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;

        public virtual double CalculateDiscount(double price)
        {
            throw new NotImplementedException();
        }

        public abstract void DisplayProductNameDetails();

        public void DisplayProductDetailsOnly()
        {
            Console.WriteLine("Product Name: " + ProductName);
        }
    }

}