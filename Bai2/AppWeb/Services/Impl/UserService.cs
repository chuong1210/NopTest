using api_be.Infrastructure.DB;
using AppWeb.DTO;
using AppWeb.Model;
using AppWeb.Request;
using AppWeb.Responses;
using AutoMapper;
using System.Reflection;

namespace AppWeb.Services.Impl
{
    public class UserService : IUserservice
    {
        private readonly ISupermarketDbContext _context;
        private readonly IMapper _mapper;


        public UserService(ISupermarketDbContext pContext,IMapper mapper) {
            _context = pContext;
            _mapper = mapper;
        }
        public async Task<Result<UserDTO>> Create(CreateUserRequest request)
        {
                            var user = _mapper.Map<User>(request);

            var newUser = await _context.Users.AddAsync(user);

            var userDto = _mapper.Map<UserDTO>(newUser.Entity);
            return Result<UserDTO>.Success(userDto, StatusCodes.Status201Created);


        }

        public async Task<Result<bool>> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
       

            _context.Users.Remove(user);
            return Result<bool>.Success(true, StatusCodes.Status200OK);
        }

        public Task<Result<UserDTO>> Detail(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> ForgotPass(string username)
        {
            throw new NotImplementedException();
        }

    
        public Task<Result<bool>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Result<UserDTO>> Update(UpdateUserRequest request)
        {
            throw new NotImplementedException();
        }


    }
}
