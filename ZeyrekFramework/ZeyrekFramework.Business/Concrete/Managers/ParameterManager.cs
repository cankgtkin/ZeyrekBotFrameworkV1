using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class ParameterManager : IParameterService
    {
        private readonly IParameterDal _parameterDal;

        public ParameterManager(IParameterDal parameterDal)
        {
            _parameterDal = parameterDal; 
        }
        
        public Task<List<Parameter>> GetParameterList(string intentId)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Parameter/GetByParameterIntendId/" + intentId;
            return _parameterDal.GetList(baseUrl, url);
        }

        public Task<Parameter> GetParameter(string intentId, string parameterName)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Parameter/GetParameterByIntendIdAndParameterName";
            url += "?id=" + intentId;
            url += "&name=" + parameterName;
            return _parameterDal.Get(baseUrl, url);
        }
    }
}
