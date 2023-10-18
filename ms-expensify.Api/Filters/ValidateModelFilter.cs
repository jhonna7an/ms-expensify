using Microsoft.AspNetCore.Mvc.Filters;

namespace ms_expensify.Api.Filters
{
    public class ValidateModelFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();

                string errorMessage = string.Join(", ", errors);

                throw new Exception("ModelState is not valid: " + errorMessage);
            }
        }
    }
}
