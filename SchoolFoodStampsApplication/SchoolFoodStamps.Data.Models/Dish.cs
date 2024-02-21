namespace SchoolFoodStamps.Data.Models
{
    public class Dish
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Weight { get; set; }

        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; } = null!;
    }
}