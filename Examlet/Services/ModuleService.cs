using Examlet.Data;
using Microsoft.EntityFrameworkCore;

namespace Examlet.Services {
    public class ModuleService {
        private readonly ExamletContext _context;
        public ModuleService(ExamletContext context) {
            _context = context;
        }
    }
}