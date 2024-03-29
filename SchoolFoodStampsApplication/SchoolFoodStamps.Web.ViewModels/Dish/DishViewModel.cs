namespace SchoolFoodStamps.Web.ViewModels.Dish
{
    public class DishViewModel
    {
        public DishViewModel()
        {
            Allergens = new HashSet<string>();
        }
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Weight { get; set; } = string.Empty;

        public IEnumerable<string> Allergens { get; set; }
    }
}
