using Goof.Infraestructure.Repository.Generic;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Application.Contracts.Repositories
{
    public interface ITransactionsRepository : IRepository<Transaction>
    {
        void UpdateRange(List<Transaction> entitiesToUpdate, CancellationToken cancellationToken);
    }
}
