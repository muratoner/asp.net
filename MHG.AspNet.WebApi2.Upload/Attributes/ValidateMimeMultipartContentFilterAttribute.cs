using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MHG.AspNet.WebApi2.Upload.Attributes {
    internal class ValidateMimeMultipartContentFilterAttribute : ActionFilterAttribute {
        public override void OnActionExecuting( HttpActionContext actionContext ) {
            if( !actionContext.Request.Content.IsMimeMultipartContent() )
                throw new HttpResponseException( HttpStatusCode.UnsupportedMediaType );
        }
    }
}