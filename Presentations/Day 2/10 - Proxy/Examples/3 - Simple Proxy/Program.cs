using System.Security.Principal;
using Wincubate.ProxyExamples;
using Wincubate.ProxyExamples.WebShop;

AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

IProductRepository products = new AdministratorsOnlySimpleProxy();
products.Add(new Product(7, "Proxying Proxies", "P. Atternborough", Category.Book));

IEnumerable<Product> books = products
                .GetAll()
                .Where(p => p.Category == Category.Book);

foreach (Product product in books)
{
    Console.WriteLine(product);
}

Console.WriteLine("Done...");
Console.ReadLine();
