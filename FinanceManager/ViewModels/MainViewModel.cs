using System.ComponentModel;
using System.Runtime.CompilerServices;

using FinanceManager.Commands;
using FinanceManager.Domain;
using FinanceManager.Infrastructure.Repositories;

namespace FinanceManager.Models
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private BaseRepository<User> _userRepository;
        public MainViewModel(int userId = 1)
        {
            _userRepository = new BaseRepository<User>();
            GetUserData(userId);
        }

        private User _user;
        public User User
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

        /*private RelayCommand _updateBalance;
        public RelayCommand UpdateBalance
        {
            get
            {
                return _updateBalance = new RelayCommand(obj =>
                {
                    Balance = "100";
                });
            }
        }*/

        private void GetUserData(int userId)
        {
            _user = _userRepository.GetById(userId);
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
