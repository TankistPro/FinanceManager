using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FinanceManager.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _code;
        private string _balance;
        private string? _avatarHash;

        public int Id { 
            get { return _id; } 
            set { _id = value; } 
        }
        public string FirstName { 
            get { return _firstName; } 
            set { _firstName = value; } 
        }
        public string LastName { 
            get { return _lastName; } 
            set { _lastName = value; } 
        }
        public string Email { 
            get { return _email; } 
            set { _email = value; } 
        }
        public string Code { 
            get { return _code; } 
            set { _code = value; } 
        }
        public string Balance { 
            get { return _balance; }
            set { _balance = value; }
        }
        public string? AvatarHash { 
            get { return _avatarHash; } 
            set { _avatarHash = value; } 
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
