﻿
namespace Examlet.ViewModels {
    public class CardVM {
        public int Id { get; set; }
        public required string Term { get; set; }
        public string? Definition { get; set; }
        public int ModuleId { get; set; }
        public ModuleVM Module { get; set; } = null!;
    }
}