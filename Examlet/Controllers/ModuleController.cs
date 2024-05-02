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
            return PartialView("/Views/Card/_Card.cshtml", new CardVM());
        }

        public IActionResult GetCardPlainHtml() {
            var idx = -1;
            var termAtt = "data-card-term='new'";
            var defitionAtt = "data-card-definition='new'";
            var html = @$"<div style=""display:flex; gap: 10px; box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);transition: 0.3s;border-radius: 5px; padding: 5px; background-color: #FFFFFF"">
                            <input type=""hidden"" data-val=""true"" data-val-required=""The Id field is required."" id=""Cards_{idx}__Id"" name=""Cards[{idx}].Id"" value=""0"">
    
                            <div style=""display: flex; gap: 10px; flex-grow: 1"">
                                <div style=""flex-grow: 1"">
                                    <label class=""control-label"" for=""Cards_{idx}__Term"">Term</label>
                                    <input {termAtt} class=""form-control"" style=""min-width: 400px"" type=""text"" id=""Cards_{idx}__Term"" name=""Cards[{idx}].Term"" value="""">
                                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""Cards[{idx}].Term"" data-valmsg-replace=""true""></span>
                                </div>
                                <div style=""flex-grow: 1"">
                                    <label class=""control-label"" for=""Cards_{idx}__Definition"">Definition</label>
                                    <textarea {defitionAtt} class=""form-control"" style=""min-width: 400px;"" rows=""5"" id=""Cards_{idx}__Definition"" name=""Cards[{idx}].Definition""></textarea>
                                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""Cards[{idx}].Definition"" data-valmsg-replace=""true""></span>
                                </div>
                            </div>
                        </div>";

            return Ok(html);
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
