using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IParameterService
    {
        [OperationContract]
        Task<List<Parameter>> GetParameterList(string intentId);

        [OperationContract]
        Task<Parameter> GetParameter(string intentId,string parameterName);
    }
}
