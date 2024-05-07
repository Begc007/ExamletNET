using AutoMapper;
using Examlet.Filters;
using Examlet.Models;
using Examlet.Services;
using Examlet.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examlet.Controllers {
    public class ModuleController : Controller {
        private readonly ModuleService _moduleService;
        private readonly IMapper _mapper;
        public ModuleController(ModuleService moduleService, IMapper mapper) {
            _moduleService = moduleService;
            _mapper = mapper;
        }
        // GET: ModuleController
        public ActionResult Index() {
            return View();
        }

        // GET: ModuleController/Details/5
        [ModuleExistActionFilter]
        public ActionResult Details(int id) {
            var module = _moduleService.GetWithCards(id);
            var model = _mapper.Map<ModuleVM>(module);
            //if(model is null) {
            //    Response.StatusCode = StatusCodes.Status404NotFound;
            //    return View("~/Views/Shared/404.cshtml");
            //}
            return View(nameof(Details), model);
        }

        [HttpGet]
        public IActionResult GetCardPlainHtml() {
            var idx = -1;
            var termAtt = "data-card=\"term\"";
            var defitionAtt = "data-card=\"definition\"";
            var html = @$"<div style=""display:flex; gap: 10px; box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);transition: 0.3s;border-radius: 5px; padding: 5px; background-color: #FFFFFF"">
                            <input type=""hidden"" data-val=""true"" data-val-required=""The Id field is required."" id=""Cards_{idx}__Id"" name=""Cards[{idx}].Id"" value=""0"">
    
                            <div data-card=""container"" style=""display: flex; gap: 10px; flex-grow: 1"">
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

            return View(nameof(Create), model);
        }

        // POST: ModuleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModuleVM model) {
            try {
                if (!ModelState.IsValid) {
                    return View(model);
                }

                var module = _mapper.Map<Module>(model);
                var id = _moduleService.Create(module);

                return RedirectToAction(nameof(Details), new { id });
            } catch {
                return View();
            }
        }

        // GET: ModuleController/Edit/5
        [ModuleExistActionFilter]
        public ActionResult Edit(int id) {
            var model = _mapper.Map<ModuleVM>(_moduleService.GetWithCards(id));
            //if (model is null) {
            //    Response.StatusCode = StatusCodes.Status404NotFound;
            //    return View("~/Views/Shared/404.cshtml");
            //}

            return View(nameof(Edit), model);
        }

        // POST: ModuleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ModuleVM model) {
            try {
                if (!ModelState.IsValid) {
                    return View(model);
                }
                return RedirectToAction(nameof(Edit));
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
