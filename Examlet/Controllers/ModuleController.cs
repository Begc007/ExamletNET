using Examlet.Services;
using Examlet.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examlet.Controllers {
    public class ModuleController : Controller {
        private readonly ModuleService _moduleService;
        public ModuleController(ModuleService moduleService)
        {
            _moduleService = moduleService;
        }
        // GET: ModuleController
        public ActionResult Index() {
            return View();
        }

        // GET: ModuleController/Details/5
        public ActionResult Details(int id) {
            return View();
        }
        public ActionResult GetCard() {
            return PartialView("/Views/Shared/EditorTemplates/CardVM.cshtml", new CardVM());
        }
        // GET: ModuleController/Create
        public ActionResult Create() {
            var model = new ModuleVM();
            model.Id = 1;
            //model.Cards.Add(new CardVM() { Id = 1, Term="A", Definition = "AA"});
            //model.Cards.Add(new CardVM() { Id = 2, Term = "B", Definition = "BB" });
            //model.Cards.Add(new CardVM() { Id = 3, Term = "C", Definition = "CC" });
            model.Cards.Add(new CardVM() );
            model.Cards.Add(new CardVM() );
            model.Cards.Add(new CardVM() );

            return View(nameof(Create), model);
        }

        // POST: ModuleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModuleVM model) {
            try {
                return RedirectToAction(nameof(Create));
            } catch {
                return View();
            }
        }

        // GET: ModuleController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: ModuleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: ModuleController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: ModuleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
