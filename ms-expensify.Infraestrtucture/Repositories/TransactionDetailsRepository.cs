using Goof.Infraestructure.Repository.Context;
using Goof.Infraestructure.Repository.Generic;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Infraestructure.Repositories
{
    public class TransactionDetailsRepository : BaseRepository<TransactionDetail>, ITransactionDetailsRepository
    {
        public TransactionDetailsRepository(IDbContext context) : base(context)
        {
        }
    }
}
