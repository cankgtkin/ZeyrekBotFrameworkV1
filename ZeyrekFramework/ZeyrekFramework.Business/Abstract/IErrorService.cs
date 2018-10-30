using System.ServiceModel;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    [ServiceContract]
    public interface IErrorService
    {
        [OperationContract]
        Task<string> SetError(Error data);
    }
}
