using MicroTest.Web.Models;

namespace MicroTest.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto);
        Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto);
    }
}
