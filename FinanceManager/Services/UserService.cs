using AutoMapper;
using FinanceManager.Domain;
using FinanceManager.Infrastructure.Repositories;
using FinanceManager.Interfaces;
using FinanceManager.Models;

namespace FinanceManager.Services
{
    internal class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly BaseRepository<User> _userRepository;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = new BaseRepository<User>();
        }

        public UserModel GetUserData(int userId)
        {
            var user = _userRepository.GetById(userId);

            return _mapper.Map<UserModel>(user);
        }
    }
}
