namespace FinanceNewsPortal.Web.ViewModels
{
    public class CompanyDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime FoundedAt { get; set; }
        public string ImageFilePath { get; set; }
        public int StaffCount { get; set; } = 0;
    }
}
