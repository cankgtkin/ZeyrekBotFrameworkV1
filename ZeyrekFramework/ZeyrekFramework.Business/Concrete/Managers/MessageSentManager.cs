using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class MessageSentManager : IMessageSentService
    {
        private readonly IMessageSentDal _messageSentDal;

        public MessageSentManager(IMessageSentDal messageSentDal)
        {
            _messageSentDal = messageSentDal; 
        }
        
        public Task<MessageSent> GetMessageSent(string referanceId, int type)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "MessageSent/GetMessageSentId";
            url += "?id=" + referanceId;
            url += "&type=" + type.ToString();
            return _messageSentDal.Get(baseUrl, url);
        }
    }
}
