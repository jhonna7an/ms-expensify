namespace ms_expensify.Application.Services.Plannings.ViewModels
{
    public class PlanningPatchViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}

