using Spectre.Console;

namespace CoffeeShop.PointOfSale.EntityFramework;
static internal class UserInterface
{
    static internal void ShowProductTable(List<Product> products)
    {
        var table = new Table();
        table.AddColumn("Id");
        table.AddColumn("Name");

        foreach (var product in products)
        {
            table.AddRow(product.Id.ToString(), product.Name);
        }

        AnsiConsole.Write(table);

        Console.WriteLine("Enter any key to continue");
        Console.ReadLine();
        Console.Clear();
    }
}
