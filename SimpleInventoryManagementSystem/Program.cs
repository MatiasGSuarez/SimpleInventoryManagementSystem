using SimpleInventoryManagementSystem.Domain.ProductManagement;

Inventory inventory = new Inventory(); 
var createdProduct = inventory.CreateProduct();
inventory.AddProduct(createdProduct);
inventory.ShowProducts(); 