using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface ISessionService
    {
        [OperationContract]
        Task<string> SetSession(Session data);

        [OperationContract]
        Task<string> UpdateSession(Session data);
    }
}
