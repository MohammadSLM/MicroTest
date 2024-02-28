using MicroTest.Web.Models;

namespace MicroTest.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> GetCouponByCodeAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsync(int id);
    }
}
