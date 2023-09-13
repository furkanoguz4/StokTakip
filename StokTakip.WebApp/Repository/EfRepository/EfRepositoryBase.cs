using StokTakip.WebApp.Models;

namespace StokTakip.WebApp.Repository.EfRepository;

// Bütün entity classlarımız için ortak sınıf
// bütün tablolarda crud operasyonları ortak bunu tek bir sınıfta yazıp her yerde kullanmak istediğimiz için böyle bir yapı kurdum.
public class EfRepositoryBase<TEntity> : IBaseRepository<TEntity> where TEntity : Entity, new()
{

    private readonly BaseDbContext _context;
    public EfRepositoryBase(BaseDbContext context)
    {
        _context = context;
    }

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        TEntity entity = _context.Set<TEntity>().Where(x => x.Id == id).SingleOrDefault();
        _context.Remove(entity);
        _context.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
      return  _context.Set<TEntity>().SingleOrDefault(X=>X.Id==id);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
    }
}
