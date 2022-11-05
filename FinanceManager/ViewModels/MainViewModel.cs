using System.ComponentModel;
using System.Runtime.CompilerServices;
using AutoMapper;
using FinanceManager.Commands;
using FinanceManager.Domain;
using FinanceManager.Infrastructure.Repositories;
using FinanceManager.Services;

namespace FinanceManager.Models
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel(IMapper mapper, int userId = 1)
        {
            User = new UserService(mapper).GetUserData(userId);
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
