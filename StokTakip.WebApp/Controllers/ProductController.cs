using Microsoft.AspNetCore.Mvc;
using StokTakip.WebApp.Models;
using StokTakip.WebApp.Models.Dtos;
using StokTakip.WebApp.Repository;

namespace StokTakip.WebApp.Controllers;
public class ProductController : Controller
{


    private readonly BaseDbContext _baseDbContext;

    public ProductController(BaseDbContext baseDbContext)
    {
        _baseDbContext = baseDbContext;
    }
    public IActionResult Index()
    {
        var products = _baseDbContext.Products.ToList();

        List<ProductDto> productsDtoList = new();

        foreach (var product in products)
        {
          ProductDto productDto = new ProductDto()
          {
              Dealer = product.Dealer,
              Description = product.Description,
              Id = product.Id,  
              Name = product.Name,
              Price = product.Price,
              Stock = product.Stock
          };
            productsDtoList.Add(productDto);
        }

        ProductViewModel viewModel = new ProductViewModel()
        {
            ProductDtos = productsDtoList,
            TotalStock = products.Sum(x=>x.Stock)
        };

        return View(viewModel);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Create(ProductCreateDto productDto)
    {
        //Product product = new Product()
        //{
        //    Dealer=productDto.Dealer,
        //    Description = productDto.Description,   
        //    Name = productDto.Name, 
        //    Price = productDto.Price,
        //    Stock = productDto.Stock    

        //};
        Product product = productDto;
        _baseDbContext.Add(product);
        _baseDbContext.SaveChanges();
        return RedirectToAction("Index","Product");
    }

    public IActionResult Details(int id)
    {
        Product? product = _baseDbContext.Products.SingleOrDefault(x => x.Id == id);
        return View(product);
    }


    [HttpGet]
    public IActionResult Update(int id)
    {
        var product = _baseDbContext.Products.Find(id);
        return View(product);
    }

    [HttpPost]
    public IActionResult Update(Product product)
    {
        _baseDbContext.Products.Update(product);
        _baseDbContext.SaveChanges();

        return RedirectToAction("Details","Product",new {id=product.Id});
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = _baseDbContext.Products.Find(id);

        _baseDbContext.Products.Remove(product);
        _baseDbContext.SaveChanges();

        return RedirectToAction("Index","Product");
    }
}
