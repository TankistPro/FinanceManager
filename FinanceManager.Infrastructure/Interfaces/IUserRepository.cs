
using FinanceManager.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> UpdateBalance(double newBalance, int userId);
    }
}
