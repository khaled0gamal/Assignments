using EntityFramework_assignment_1.data;
using EntityFramework_assignment_1.Models;

namespace EntityFramework_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreContext context = new StoreContext();
            //** shwow all categories
            var categories = context.Categories.ToList();
            foreach (var category in categories)
            {
                Console.WriteLine($"Category ID: {category.CategoryId}, Name: {category.Name}");
            }
            //-------------------------------------------------
            //** show all products
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price}, Category ID: {product.CategoryId}");
            }
            //-------------------------------------------------
            //** Add a new category
            //Console.WriteLine("add new category name");
            //var CategoryName = Console.ReadLine();
            //context.Categories.Add(new Category
            //{
            //    Name = CategoryName
            //});
            //context.SaveChanges();
            //Console.WriteLine("added");
            //----------------------------------------------
            //** update a category
            //Console.WriteLine("Enter the ID of the category to update:");
            //var categoryId = int.Parse(Console.ReadLine());
            //var categoryToUpdate = context.Categories.Find(categoryId);
            //if (categoryToUpdate != null)
            //{
            //    Console.WriteLine("Enter the new name for the category:");
            //    var newName = Console.ReadLine();
            //    categoryToUpdate.Name = newName;
            //    context.SaveChanges();
            //    Console.WriteLine("Category updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Category not found.");
            //}
            //-------------------------------------------------
            //** add a new product
            //Console.WriteLine("Enter the name of the new product:");
            //var productName = Console.ReadLine();
            //Console.WriteLine("Enter the price of the new product:");
            //var productPrice = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the category ID for the new product:");
            //var productCategoryId = int.Parse(Console.ReadLine());
            //context.Products.Add(new Product
            //{
            //    Name = productName,
            //    Price = productPrice,
            //    CategoryId = productCategoryId
            //});
            //context.SaveChanges();
            //Console.WriteLine("Product added successfully.");
            //-------------------------------------------------
            //** update a product
            //Console.WriteLine("Enter the ID of the product to update:");
            //var productId = int.Parse(Console.ReadLine());
            //var productToUpdate = context.Products.Find(productId);
            //Console.WriteLine(
            //    $"Product ID: {productToUpdate.ProductId}, Name: {productToUpdate.Name}, Price: {productToUpdate.Price}, Category ID: {productToUpdate.CategoryId}");
            //if (productToUpdate != null)
            //{
            //    Console.WriteLine(
            //        "Enter the new name for the product (leave blank to keep current name):");
            //    var newName = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(newName))
            //    {
            //        productToUpdate.Name = newName;
            //    }
            //    Console.WriteLine(
            //        "Enter the new price for the product (leave blank to keep current price):");
            //    var newPriceInput = Console.ReadLine();
            //    if (decimal.TryParse(newPriceInput, out var newPrice))
            //    {
            //        productToUpdate.Price = newPrice;
            //    }
            //    Console.WriteLine(
            //        "Enter the new category ID for the product (leave blank to keep current category):");
            //    var newCategoryIdInput = Console.ReadLine();
            //    if (int.TryParse(newCategoryIdInput, out var newCategoryId))
            //    {
            //        productToUpdate.CategoryId = newCategoryId;
            //    }
            //    context.SaveChanges();
            //    Console.WriteLine("Product updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            //-------------------------------------------------
            //** delete a category
            //Console.WriteLine("Enter the ID of the category to delete:");
            //var categoryIdToDelete = int.Parse(Console.ReadLine());
            //var categoryToDelete = context.Categories.Find(categoryIdToDelete);
            //if (categoryToDelete != null)
            //{
            //    context.Categories.Remove(categoryToDelete);
            //    context.SaveChanges();
            //    Console.WriteLine("Category deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Category not found.");
            //}
            //-------------------------------------------------
            //** delete a product
            //Console.WriteLine("Enter the ID of the product to delete:");
            //var productIdToDelete = int.Parse(Console.ReadLine());
            //var productToDelete = context.Products.Find(productIdToDelete);
            //if (productToDelete != null)
            //{
            //    context.Products.Remove(productToDelete);
            //    context.SaveChanges();
            //    Console.WriteLine("Product deleted successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            //-------------------------------------------------
        }
    }
}
