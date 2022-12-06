namespace WebHost.Models
{
    public class Recipe
    {
        public Guid id { get; set; }
        public string? title { get; set; }

        public ICollection<Step> Steps { get; set; }
    }
}
