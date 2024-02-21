namespace SchoolFoodStamps.Data.Models
{
    public class FoodStampStatus
    {
        public FoodStampStatus()
        {
            this.FoodStamps = new HashSet<FoodStamp>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<FoodStamp> FoodStamps { get; set; }
    }
}