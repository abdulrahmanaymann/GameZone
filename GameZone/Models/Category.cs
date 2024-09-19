namespace GameZone.Models
{
    public class Category : BaseEntity
    {
        // Navigation property ( one-to-many relationship)
        public ICollection<Game> Games { get; set; } = [];
    }
}
