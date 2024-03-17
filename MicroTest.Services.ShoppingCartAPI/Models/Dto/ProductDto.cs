using System.ComponentModel.DataAnnotations;

namespace MicroTest.Services.ShoppingCartAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
