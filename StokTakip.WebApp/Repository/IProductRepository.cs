using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository;

public interface IProductRepository :IBaseRepository<Product>
{
    List<Product> GetByStockRange(int min ,int max);
    List<Product> GetByContainsName(string name);

}
