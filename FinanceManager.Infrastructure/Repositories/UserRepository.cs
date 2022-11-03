using FinanceManager.Domain;
using FinanceManager.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        /// <summary>
        /// Обновление баланса пользователя
        /// </summary>
        /// <param name="newBalance"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        async public Task<bool> UpdateBalance(double newBalance, int userId)
        {
            try
            {
                var user = await _context.Set<User>().FindAsync(userId);

                if (user == null) return false;

                var updateBalance = newBalance + Convert.ToInt32(user.Balance);

                user.Balance = updateBalance.ToString();
                _context.Entry(user).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
