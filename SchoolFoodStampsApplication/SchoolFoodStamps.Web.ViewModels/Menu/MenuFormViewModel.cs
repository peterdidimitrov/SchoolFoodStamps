namespace SchoolFoodStamps.Web.ViewModels.Menu
{
    public class MenuFormViewModel
    {
        public MenuFormViewModel()
        {
            this.Dishes = new HashSet<string>();
        }
        public string DayOfWeek { get; set; } = string.Empty;

        public string CateringCompanyId { get; set; } = string.Empty;

        public ICollection<string> Dishes { get; set; }
    }
}
