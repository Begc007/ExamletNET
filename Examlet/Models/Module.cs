﻿namespace Examlet.Models {
    public class Module {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        public List<Card> Cards { get; set; }
    }
}
