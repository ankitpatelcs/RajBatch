using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionsDemo.Filters
{
    public class MyCustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            ViewResult result = new ViewResult();
            result.ViewName = "/Views/Shared/ErrorMessage.cshtml"; // new file same as Error.cshtml

            result.ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());

            result.ViewData.Model = filterContext.Exception;

            result.ViewData["Controller"] = (string)filterContext.RouteData.Values["controller"];
            result.ViewData["Action"] = (string)filterContext.RouteData.Values["action"];

            filterContext.Result = result;
            filterContext.ExceptionHandled = true;
        }
    }
}
