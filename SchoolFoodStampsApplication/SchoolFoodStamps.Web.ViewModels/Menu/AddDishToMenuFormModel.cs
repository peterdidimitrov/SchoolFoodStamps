using SchoolFoodStamps.Web.ViewModels.Dish;

namespace SchoolFoodStamps.Web.ViewModels.Menu
{
    public class AddDishToMenuFormModel
    {
        public AddDishToMenuFormModel()
        {
            this.Dishes = new List<DishViewModel>();
        }

        public string DishId { get; set; } = null!;

        public IEnumerable<DishViewModel> Dishes { get; set; }
    }
}
