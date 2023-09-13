using StokTakip.WebApp.Models;
using StokTakip.WebApp.Repository.EfRepository;

namespace StokTakip.WebApp.Repository;

public class ProductRepository : EfRepositoryBase<Product>, IProductRepository
{
    public ProductRepository(BaseDbContext context) : base(context)
    {
    }

    public List<Product> GetByContainsName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetByStockRange(int min, int max)
    {
        throw new NotImplementedException();
    }
}
