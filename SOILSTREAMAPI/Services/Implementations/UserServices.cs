using SOILSTREAMAPI.Models.Dto;
using SOILSTREAMAPI.Services.Interfaces;

namespace SOILSTREAMAPI.Services.Implementations
{
    public class UserServices : IUserServices
    {
        public Task<ResponseDto<UserMinInfoDto>> CreateUser(UserRegistrationDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserMinInfoDto>> EditUser(UserDetailsToEditDto model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<UserDetailsDto>>> GetAllAgents()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<UserDetailsDto>>> GetAllConsumers()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<UserDetailsDto>>> GetAllFarmers()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<UserDetailsDto>>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDetailsDto>> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserDetailsDto>> GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<UserMinInfoDto>> GetUserMinInfoById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
