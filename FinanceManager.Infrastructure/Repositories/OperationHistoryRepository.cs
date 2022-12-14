using FinanceManager.Domain;
using FinanceManager.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Repositories
{
    public class OperationHistoryRepository : BaseRepository<OperationHistory>, IOperationHistoryRepository
    {
        /// <summary>
        /// Создание записи о денежной операции
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        async public Task<bool> CreateOperationHistory(OperationHistory entity)
        {
            if (entity == null) return false;

            try
            {
                await this.AddAsync(entity);

                return true;
            } 
            catch (Exception ex)
            {
                return false;
            } 
        }
    }
}
