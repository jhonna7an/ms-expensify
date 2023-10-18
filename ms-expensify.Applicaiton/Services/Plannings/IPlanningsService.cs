using ms_expensify.Application.Services.Plannings.ViewModels;

namespace ms_expensify.Application.Services.Plannings
{
    public interface IPlanningsService
    {
        Task<PlanningViewModel> GetById(int id, CancellationToken cancellationToken);
        Task<List<PlanningViewModel>> GetByFilters(PlanningFilterViewModel filters, CancellationToken cancellationToken);
        Task<PlanningViewModel> Create(PlanningPostViewModel entityToAdd, CancellationToken cancellationToken);
        Task<PlanningViewModel> Patch(int id, PlanningPatchViewModel entityToUpdate, CancellationToken cancellationToken);
        Task PatchByTransactions(int id, int userId, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
