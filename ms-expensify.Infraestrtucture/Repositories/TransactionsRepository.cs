using Goof.Infraestructure.Repository.Context;
using Goof.Infraestructure.Repository.Generic;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Infraestructure.Repositories
{
    public class TransactionsRepository : BaseRepository<Transaction>, ITransactionsRepository
    {
        public TransactionsRepository(IDbContext context) : base(context)
        {
        }

        public void UpdateRange(List<Transaction> entitiesToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            _entities.UpdateRange(entitiesToUpdate);
        }
    }
}
