using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        Task<string> SetMessage(Message data);
        [OperationContract]
        Task<string> UpdateMessage(Message data);
    }
}
