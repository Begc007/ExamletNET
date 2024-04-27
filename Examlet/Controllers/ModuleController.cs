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
            return PartialView("/Views/Card/_Card.cshtml");
        }
        // GET: ModuleController/Create
        public ActionResult Create() {
            var model = new ModuleVM();
            model.Cards.Add(new CardVM());
            model.Cards.Add(new CardVM());
            model.Cards.Add(new CardVM());

            return View(nameof(Create), model);
        }

        // POST: ModuleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
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
