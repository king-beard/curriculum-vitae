using CurriculumVitaeMiddleware.Contract.Service;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumVitaeAPI.Controllers
{
    public class BaseController : Controller
    {
        public IServiceFactory ServiceFactory { get; set; }

        public BaseController(IServiceFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;
        }
    }
}
