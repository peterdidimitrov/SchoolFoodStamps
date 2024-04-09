using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Web.ViewModels.Menu
{
    public class MenuFormViewModel
    {
        public MenuFormViewModel()
        {
            this.Dishes = new HashSet<DishViewModel>();
        }

        public string Id { get; set; } = string.Empty;

        public string DayOfWeek { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public string CateringCompanyId { get; set; } = string.Empty;

        public ICollection<DishViewModel> Dishes { get; set; }
    }
}
