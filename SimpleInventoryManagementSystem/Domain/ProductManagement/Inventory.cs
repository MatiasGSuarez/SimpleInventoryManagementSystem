using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleInventoryManagementSystem.Domain.ProductManagement
{
    public class Inventory
    {
        public List<Product> Products { get; set;}
         
        public Inventory()
        {
           if(Products == null)
                Products = new List<Product>();
        }
        public Product CreateProduct()
        {
            Console.WriteLine("Enter the product id: ");
            int id = Console.Read();

            string name="";
            Console.WriteLine("Enter a name for the product.");
            while (String.IsNullOrEmpty(name))
            {
                name = Console.ReadLine();
            }

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

            return new Product(id, name, price, quantityInStock);            

        }       
        public void AddProduct(Product product)
        {

            Products.Add(product);
            Console.WriteLine("Product added succesfully.");
         
        }
        public void ShowAllProducts()
        {
            foreach(Product product in Products)
            {
                Console.WriteLine($"Product: {product.Name}\n Price: {product.Price}\n Quantity in stock {product.QuantityInStock}");
                Console.WriteLine(" ------------ ");
            }
        } 
        public void EditProduct(List<Product>products)
        {
            Console.Write("Enter the product NAME: ");
            string productName = Console.ReadLine();

            Product foundProduct = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (foundProduct != null)
            {
                Console.WriteLine($"Found Product: {foundProduct.Name}");

                Console.Write("Enter quantity: ");

                if (int.TryParse(Console.ReadLine(), out int newQuantity))
                {
                    foundProduct.QuantityInStock = newQuantity;
                }
                else
                {
                    Console.WriteLine("Invalid quantity");
                }

                Console.Write("Enter the new price: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
                {
                    foundProduct.Price = newPrice;
                }
                else
                {
                    Console.WriteLine("Succes");
                }

                Console.WriteLine("Producto actualizado con éxito.");
            }
        }
        public void DeleteProduct(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                Console.WriteLine("Please enter a product name ");
                productName = Console.ReadLine();
                return;
            }

            Product product = Products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                Products.Remove(product);
                Console.WriteLine($"Producto '{productName}' eliminado del inventario.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void FindProduct(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                Console.WriteLine("Please enter a product name ");
                productName = Console.ReadLine();
                return;
            }
            Product product = Products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                 
                Console.WriteLine($"Product '{product.Name}'\n Price {product.Price} \n Quantity in stock: {product.QuantityInStock}");
            }
        }
    }
   
}
