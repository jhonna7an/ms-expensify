using Goof.Infraestructure.Repository.Context;
using Goof.Infraestructure.Repository.Generic;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Infraestructure.Repositories
{
    public class TransactionStateRepository : BaseRepository<TransactionState>, ITransactionStateRepository
    {
        public TransactionStateRepository(IDbContext context) : base(context)
        {
        }
    }
}
