using MicroTest.Services.ShoppingCartAPI.Models.Dto;

namespace MicroTest.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
