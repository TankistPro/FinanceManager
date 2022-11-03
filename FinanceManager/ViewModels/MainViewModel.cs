using System.ComponentModel;
using System.Runtime.CompilerServices;
using AutoMapper;
using FinanceManager.Commands;
using FinanceManager.Domain;
using FinanceManager.Infrastructure.Repositories;

namespace FinanceManager.Models
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IMapper _mapper;
        private readonly BaseRepository<User> _userRepository;
        public MainViewModel(IMapper mapper, int userId = 1)
        {
            _mapper = mapper;
            _userRepository = new BaseRepository<User>();

            GetUserData(userId);
        }

        private UserModel _user;
        public UserModel User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public string Balance
        {
            get { return _user.Balance; }
            set
            {
                _user.Balance = value;
                OnPropertyChanged();
            }
        }

        private void GetUserData(int userId)
        {
            var user = _userRepository.GetById(userId);
            _user = _mapper.Map<UserModel>(user);
        }

        #region  PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
