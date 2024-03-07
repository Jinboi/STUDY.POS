using CoffeeShop.PointOfSale.EntityFramework.Models;

namespace CoffeeShop.PointOfSale.EntityFramework.Controllers;


internal class CategoryController
{
    internal static void AddCategory(Category category)
    {
        using var db = new ProductsContext();

        db.Add(category);

        db.SaveChanges();
    }
}
