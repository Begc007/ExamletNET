using Examlet.Models;
using System.ComponentModel.DataAnnotations;

namespace Examlet.ViewModels {
    public class ModuleVM {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        [MaxLength(2000)]
        public string? Description { get; set; }
        public List<CardVM> Cards { get; set; } = new List<CardVM>();

    }
}
