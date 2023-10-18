using Goof.Infraestructure.Repository.Generic;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Contracts.Repositories
{
    public interface ITransactionAccountsRepository : IRepository<TransactionAccount>
    {
        Task<bool> ExistById(int id);
    }
}
