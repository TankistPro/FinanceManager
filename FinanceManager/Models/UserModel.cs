using FinanceManager.Domain;
using FinanceManager.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FinanceManager.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        private BaseRepository<User> _userRepository;
        private User _user;

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }

        public UserModel(int userId)
        {
            _userRepository = new BaseRepository<User>();
            GetUserData(userId);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void GetUserData(int userId)
        {
            _user = _userRepository.GetById(userId);
        }
    }
}
