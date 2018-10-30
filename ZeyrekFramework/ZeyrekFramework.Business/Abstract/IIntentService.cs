using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IIntentService
    {
        [OperationContract]
        Task<Intent> GetIntent(string intentName,string applicationId);
    }
}
