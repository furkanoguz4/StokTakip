using StokTakip.WebApp.Models.Dtos;
using System.ComponentModel.DataAnnotations;

namespace StokTakip.WebApp.Models;

public class ProductViewModel
{

    public List<ProductDto> ProductDtos { get; set; }
    public int TotalStock { get; set; }
    public string SearchName { get; set; }
    public  int PageSize { get; set; }
}
