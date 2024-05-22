using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem.Domain.ProductManagement
{
    public class Inventory
    {
        public List<Product> Products { get; set;}

         
        public Inventory()
        {
           if(Products == null)
           {
                Products = new List<Product>();
           }
        }
        public Product CreateProduct()
        {
            Console.WriteLine("Product name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price:");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
            {
                Console.WriteLine("Enter a valid decimal digit value for the product.");
            }

            Console.WriteLine("Enter the quantity to add: ");
            int quantityInStock;
            while (!int.TryParse(Console.ReadLine(), out quantityInStock) || quantityInStock < 0)
            {
                Console.WriteLine("Please enter a valid digit.");
            }

            return new Product(name, price, quantityInStock);           
   

        }
       
        public void AddProduct(Product product)
        {

            Products.Add(product);
            Console.WriteLine("Product added succesfully.");
         
        }

        public void ShowProducts()
        {
            foreach(Product product in Products)
            {
                Console.WriteLine($"Product: {product.Name}\n Price: {product.Price}\n Quantity in stock {product.QuantityInStock}");
            }
        }
    }
}
