using StokTakip.WebApp.Models;
using StokTakip.WebApp.Repository.EfRepository;

namespace StokTakip.WebApp.Repository;

// S single responsibility
// O Open Closed 
// L Liskov subtition
// I iNTERFACE ayrışması 
// D Dependency Inversion

public class CategoryRepository : EfRepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context) : base(context)
    {
    }

}
