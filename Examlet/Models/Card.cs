namespace Examlet.Models {
    public class Card {
        public int Id { get; set; }
        public required string Term { get; set; }
        public string? Definition { get; set; }
        public int ModuleId { get; set; }
        public Module Module { get; set; } = null!;

    }
}
