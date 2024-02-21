namespace SchoolFoodStamps.Data.Models
{
    public class Menu
    {
        public Menu()
        {
            this.Dishes = new HashSet<Dish>();
        
        }
        public int Id { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public DateTime DateOfCreation { get; set; }

        public DateTime DateOfModify { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; }
    }
}