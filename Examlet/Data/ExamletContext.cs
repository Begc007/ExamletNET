using Examlet.Models;
using Microsoft.EntityFrameworkCore;

namespace Examlet.Data {
    public class ExamletContext : DbContext {
        public ExamletContext(DbContextOptions<ExamletContext> options):base(options) {}
        public DbSet<Module> Models { get; set; }
        public DbSet<Card> Cards { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {}
    }
}
