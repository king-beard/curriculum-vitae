using CurriculumVitaeMiddleware.Contract.Service;

namespace CurriculumVitaeAPI.Controllers
{
    public class CurriculumVitaeController : BaseController
    {
        public CurriculumVitaeController(IServiceFactory serviceFactory) : base(serviceFactory)
        {
        }
    }
}
