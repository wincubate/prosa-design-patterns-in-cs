namespace Wincubate.ProxyExamples.WebShop;

public interface IProductRepository
{
    Product GetById( int id );
    IEnumerable<Product> GetAll();
    void Add( Product product );
}
