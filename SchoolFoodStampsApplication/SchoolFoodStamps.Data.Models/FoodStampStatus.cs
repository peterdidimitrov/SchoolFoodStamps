namespace SchoolFoodStamps.Data.Models
{
    public class FoodStampStatus
    {
        public FoodStampStatus()
        {
            this.FoodStamps = new HashSet<FoodStamp>();
        }
        public int Id { get; set; }

        public required string Name { get; set; }

        public ICollection<FoodStamp> FoodStamps { get; set; }
    }
}