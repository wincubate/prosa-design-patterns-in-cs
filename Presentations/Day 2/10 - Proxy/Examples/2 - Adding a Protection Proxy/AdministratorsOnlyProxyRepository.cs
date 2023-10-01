using System.Security;
using System.Security.Principal;
using Wincubate.ProxyExamples.WebShop;

namespace Wincubate.ProxyExamples;

class AdministratorsOnlyProxyRepository : IProductRepository
{
    private readonly IProductRepository _inner;

    public AdministratorsOnlyProxyRepository(IProductRepository inner)
    {
        _inner = inner;
    }

    public IEnumerable<Product> GetAll() => _inner.GetAll();

    public Product GetById(int id) => _inner.GetById(id);

    public void Add(Product product)
    {
        EnsureAdministrator();

        _inner.Add(product);
    }

    private void EnsureAdministrator()
    {
        using WindowsIdentity identity = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new(identity);

        if (principal.IsInRole(WindowsBuiltInRole.Administrator) is false)
        {
            throw new SecurityException($"User {identity.Name} is not authorized for access");
        }
    }
}