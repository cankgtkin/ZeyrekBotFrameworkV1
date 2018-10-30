using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IMessageSentService
    {
        [OperationContract]
        Task<MessageSent> GetMessageSent(string referanceId,int type);
    }
}
