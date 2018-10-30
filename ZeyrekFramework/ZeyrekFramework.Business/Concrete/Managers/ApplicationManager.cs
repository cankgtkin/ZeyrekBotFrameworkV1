using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.Core.Aspects.Postsharp.CacheAspects;
using ZeyrekFramework.Core.CrossCuttingConcerns.Caching.Microsoft;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationDal _applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal; 
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        //[PerformanceCounterAspect(2)]
        public Task<Application> GetApplication(System.String applicationName)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Application/GetByApplicationName/"+ applicationName;
            return _applicationDal.Get(baseUrl, url);
        }
    }
}
