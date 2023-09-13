namespace StokTakip.WebApp.Models.Dtos;

public class ProductCreateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Dealer { get; set; }


    public static implicit operator Product(ProductCreateDto productCreateDto)
    {
        return new Product()
        {
            Price = productCreateDto.Price, 
            Stock = productCreateDto.Stock,
            Dealer = productCreateDto.Dealer,
            Description = productCreateDto.Description,
            Name = productCreateDto.Name
        };

    }

}
