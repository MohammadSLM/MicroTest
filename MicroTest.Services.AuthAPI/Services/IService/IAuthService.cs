using MicroTest.Services.AuthAPI.Models.Dto;

namespace MicroTest.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegisterRequestDto registerRequestDto);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
