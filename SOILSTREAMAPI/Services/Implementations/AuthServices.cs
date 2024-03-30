using SOILSTREAMAPI.Models.Dto;
using SOILSTREAMAPI.Services.Interfaces;

namespace SOILSTREAMAPI.Services.Implementations
{
    public class AuthServices : IAuthServices
    {
        Task<ResponseDto<AuthResponse>> IAuthServices.ForgotPassword(string userName)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto<AuthResponse>> IAuthServices.LoginUser(AuthRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
