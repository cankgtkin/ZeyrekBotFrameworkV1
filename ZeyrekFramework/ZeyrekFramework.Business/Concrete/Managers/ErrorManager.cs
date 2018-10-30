using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class ErrorManager : IErrorService
    {
        private readonly IErrorDal _errorDal;

        public ErrorManager(IErrorDal errorDal)
        {
            _errorDal = errorDal; 
        }
        
        public Task<string> SetError(Error data)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "ErrorLog/Create";
            url += "?SessionId=" + data.SessionId;
            url += "&FunctionName=" + data.FunctionName;
            url += "&DialogName=" + data.DialogName;
            url += "&ErrorMessage=" + data.ErrorMessage;
            url += "&ErrorType=" + data.ErrorType;
            url += "&ErrorTime=" + data.ErrorTime;
            return _errorDal.Add(baseUrl, url);
        }
    }
}
