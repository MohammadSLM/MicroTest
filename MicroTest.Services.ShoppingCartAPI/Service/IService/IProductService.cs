using MicroTest.Services.ShoppingCartAPI.Models.Dto;

namespace MicroTest.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
