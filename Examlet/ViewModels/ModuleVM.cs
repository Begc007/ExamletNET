using Examlet.Models;

namespace Examlet.ViewModels {
    public class ModuleVM {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();

    }
}
