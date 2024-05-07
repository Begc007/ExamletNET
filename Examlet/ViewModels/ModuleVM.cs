using System.ComponentModel.DataAnnotations;

namespace Examlet.ViewModels {
    
    public class ModuleVM:IValidatableObject {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
        [MaxLength(2000)]
        public string? Description { get; set; }
        
        public List<CardVM> Cards { get; set; } = new List<CardVM>() { new CardVM(), new CardVM(), new CardVM()};

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            var maxBlankCards = 3;
            if (Cards.Count(c => string.IsNullOrWhiteSpace(c.Term) && string.IsNullOrWhiteSpace(c.Definition)) >= maxBlankCards) {
                yield return new ValidationResult($"The maximum number of blank cards is {maxBlankCards}", new[] { nameof(Cards) });
            }
        }
    }
}
