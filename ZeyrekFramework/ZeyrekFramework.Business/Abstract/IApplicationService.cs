using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract]
        Task<Application> GetApplication(string applicationName);
    }
}
