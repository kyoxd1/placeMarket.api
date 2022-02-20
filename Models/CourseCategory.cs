namespace placeMarket.api.Models
{
    public class CourseCategory
    {
        public int Id { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}