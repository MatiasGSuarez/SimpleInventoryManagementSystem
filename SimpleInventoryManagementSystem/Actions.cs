using SimpleInventoryManagementSystem.Domain.ProductManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem
{
    public class Actions
    {
        Inventory inventory {  get; set; }
        
        public Actions()         
        {
            this.inventory = new Inventory();
        }             
 
        public void ShowMainMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("** Select an action **");
                Console.WriteLine("1: Create and add a new product");
                Console.WriteLine("2: View all products");
                Console.WriteLine("3: Edit a product");
                Console.WriteLine("3: Delete a product");
                Console.WriteLine("0: Close application");
                Console.WriteLine("Your selection: ");
                string userSelection = Console.ReadLine();
                while (userSelection != "0")
                {

                    if (!String.IsNullOrEmpty(userSelection))
                    {
                        switch (userSelection)
                        {
                            case "1":
                                var product = inventory.CreateProduct();
                                inventory.AddProduct(product);
                                break;
                            case "2":
                                inventory.ShowAllProducts();
                                Console.WriteLine("Presione cualquier tecla para continuar"); 
                                Console.Read();
                                break;
                            case "3":
                                inventory.EditProduct(inventory.Products);
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                Console.Read();
                                break;
                            case "4":
                                Console.WriteLine("Enter the product name");
                                var productName = Console.ReadLine();
                                inventory.DeleteProduct(productName);
                                Console.WriteLine("Presione cualquier tecla para continuar");
                                Console.Read();
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                    ShowMainMenu();
                }
                Console.WriteLine("Bye");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
            }
        }
    }
}
