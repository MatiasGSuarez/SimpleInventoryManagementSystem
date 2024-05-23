using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem.Domain.ProductManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }



        public Product(int id, string name, decimal price, int quantityInStock)
        {
            Id = id; 
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        #region Methods


        #endregion

    }
}
 