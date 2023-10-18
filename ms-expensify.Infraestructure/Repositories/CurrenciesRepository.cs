using Goof.Infraestructure.Repository.Context;
using Goof.Infraestructure.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Domain.Entities;

namespace ms_expensify.Infraestructure.Repositories
{
    public class CurrenciesRepository : BaseRepository<Currency>, ICurrenciesRepository
    {
        public CurrenciesRepository(IDbContext context) : base(context)
        {
        }

        public Task<bool> ExistById(int id) => _entities.AnyAsync(ent => ent.Id == id);
    }
}
