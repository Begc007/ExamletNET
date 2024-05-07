using AutoMapper;
using Examlet.Data;
using Examlet.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Examlet.Services {
    public class ModuleService {
        private readonly ExamletContext _context;
        
        public ModuleService(ExamletContext context) {
            _context = context;
            
        }

        public int Create(Module module) {
            _context.Add(module);
            _context.SaveChanges();
            return module.Id;
        }

        public Module? Get(int id) {
            return _context.Modules.SingleOrDefault(m => m.Id == id);
        }
        
        public Module? GetWithCards(int id) {
            return _context.Modules.Include(m => m.Cards).SingleOrDefault(m => m.Id == id);
        }

        public bool Exists(int id) {
            return _context.Modules.Any(m => m.Id == id);
        }
    }
}