using AutoMapper;
using AutoMapper.QueryableExtensions;
using Goof.Infraestructure.Repository.UoW;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Application.Services.TransactionDetails
{
    public class TransactionDetailsService : ITransactionDetailsService
    {
        private readonly ITransactionDetailsRepository _transactionDetailsRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionDetailsService(
            ITransactionDetailsRepository transactionDetailsRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork
        )
        {
            _transactionDetailsRepository = transactionDetailsRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<TransactionDetailViewModel> GetById(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionDetail> applyFilters(IQueryable<TransactionDetail> query) => _applyFilters(query, new TransactionDetailFilterViewModel
            {
                Id = id
            });

            IQueryable<TransactionDetail> transactionAccounts = _transactionDetailsRepository.GetByFilters(applyFilters, cancellationToken: cancellationToken);

            return await transactionAccounts.ProjectTo<TransactionDetailViewModel>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<TransactionDetailViewModel> Create(int transactionId, TransactionDetailPostViewModel entityToAdd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            TransactionDetail transactionDetail = _mapper.Map<TransactionDetail>(entityToAdd);
            transactionDetail.TransactionId = transactionId;

            await _transactionDetailsRepository.Insert(transactionDetail, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transactionDetail.Id, cancellationToken);
        }

        public async Task<TransactionDetailViewModel> Patch(int id, TransactionDetailPatchViewModel entityToUpdate, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionDetail> applyFilters(IQueryable<TransactionDetail> query) => _applyFilters(query, new TransactionDetailFilterViewModel
            {
                Id = id
            });

            TransactionDetail transactionAccount = _transactionDetailsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transactionAccount is null)
                throw new Exception("No se encontró la cuenta");

            _mapper.Map(entityToUpdate, transactionAccount);

            _transactionDetailsRepository.Update(transactionAccount, cancellationToken);
            _unitOfWork.SaveChanges();

            return await GetById(transactionAccount.Id, cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            IQueryable<TransactionDetail> applyFilters(IQueryable<TransactionDetail> query) => _applyFilters(query, new TransactionDetailFilterViewModel
            {
                Id = id
            });

            TransactionDetail transactionAccount = _transactionDetailsRepository
                .GetByFilters(applyFilters, cancellationToken: cancellationToken)
                .FirstOrDefault()!;

            if (transactionAccount is null)
                throw new Exception("No se encontró el detalle de la transacción");

            _transactionDetailsRepository.Delete(transactionAccount, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
        }

        private IQueryable<TransactionDetail> _applyFilters(IQueryable<TransactionDetail> query, TransactionDetailFilterViewModel filters)
        {
            query = query.Where(x => x.Status != (int)StatusEnum.Deleted).AsQueryable();

            if (filters.Id.HasValue)
                query = query.Where(x => x.Id == filters.Id.Value);

            return query;
        }
    }
}
