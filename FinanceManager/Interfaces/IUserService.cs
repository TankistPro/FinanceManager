using FinanceManager.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceManager.Interfaces
{
    internal interface IUserService
    {
        public UserModel GetUserData(int userId);
    }
}
