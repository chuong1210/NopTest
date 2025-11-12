using AppWeb.DTO;
using AppWeb.Request;
using AppWeb.Responses;

namespace AppWeb.Services
{
    public interface IUserservice
    {
        public Task<Result<UserDTO>> Create(CreateUserRequest request);
        public Task<Result<UserDTO>> Update(UpdateUserRequest request);
        public Task<Result<Boolean>> Delete(int id);
        public Task<Result<UserDTO>> Detail( int ID);
        public Task<Result<bool>> Login(string username,string password);
        public Task<Result<bool>> ForgotPass(string usernam);


    }
}
