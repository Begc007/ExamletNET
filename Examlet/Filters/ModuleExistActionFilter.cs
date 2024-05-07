using Examlet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;

namespace Examlet.Filters {
    public class ModuleExistActionFilter:ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext context) {
            base.OnActionExecuting(context);
            var moduleId = (int)context.ActionArguments["id"]!;
            var service = context.HttpContext.RequestServices.GetService<ModuleService>();
            if (!service.Exists(moduleId)) {
                context.Result = new ViewResult {
                    ViewName = "~/Views/Shared/404.cshtml",
                    StatusCode = StatusCodes.Status404NotFound    
                };
            }
        }
    }
}
