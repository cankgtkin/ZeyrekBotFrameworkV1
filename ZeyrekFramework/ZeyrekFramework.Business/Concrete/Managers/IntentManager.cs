using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class IntentManager : IIntentService
    {
        private readonly IIntentDal _intentDal;

        public IntentManager(IIntentDal intentDal)
        {
            _intentDal = intentDal; 
        }
        
        public Task<Intent> GetIntent(string intentName, string applicationId)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Intend/GetIntendByNameAndApplicationId";
            url += "?name=" + intentName;
            url += "&applicationId=" + applicationId;
            return _intentDal.Get(baseUrl, url);
        }
    }
}
