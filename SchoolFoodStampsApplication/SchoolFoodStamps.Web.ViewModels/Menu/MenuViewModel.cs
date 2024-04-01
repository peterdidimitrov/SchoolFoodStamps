using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Web.ViewModels.Menu
{
    public class MenuViewModel
    {
        public MenuViewModel()
        {
            this.Dishes = new HashSet<DishViewModel>();
        }
        public int Id { get; set; }

        public string DayOfWeek { get; set; } = string.Empty;

        public string CateringCompanyId { get; set; } = string.Empty;

        public ICollection<DishViewModel> Dishes { get; set; }
    }
}
