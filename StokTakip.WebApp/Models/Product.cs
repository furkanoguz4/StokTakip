using System.ComponentModel.DataAnnotations;

namespace StokTakip.WebApp.Models;
public class Product :Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Dealer { get; set; }

}
