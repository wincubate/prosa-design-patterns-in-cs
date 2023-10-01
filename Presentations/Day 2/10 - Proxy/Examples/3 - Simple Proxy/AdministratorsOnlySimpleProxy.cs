using System.Security;
using System.Security.Principal;
using Wincubate.ProxyExamples.WebShop;

namespace Wincubate.ProxyExamples;

class AdministratorsOnlySimpleProxy : ProductRepository
{
    public override void Add( Product product )
    {
        EnsureAdministrator();

        base.Add(product);
    }

    private void EnsureAdministrator()
    {
        using WindowsIdentity identity = WindowsIdentity.GetCurrent();
        WindowsPrincipal principal = new(identity);

        if (principal.IsInRole(WindowsBuiltInRole.Administrator) is false )
        {
            throw new SecurityException($"User {identity.Name} is not authorized for access");
        }
    }
}