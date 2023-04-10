using Microsoft.AspNetCore.Mvc.Filters;

namespace Invo.izin.Yönetim.Sistemi.WebAPI.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {

            }
            base.OnActionExecuting(context);
        }

    }
}