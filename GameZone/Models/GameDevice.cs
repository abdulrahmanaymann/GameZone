namespace GameZone.Models
{
    public class GameDevice
    {
        public int GameId { get; set; } // Foreign key

        // Navigation property ( many-to-many relationship)
        public Game Game { get; set; } = default!;

        public int DeviceId { get; set; } // Foreign key

        // Navigation property ( many-to-many relationship)
        public Device Device { get; set; } = default!;
    }
}
