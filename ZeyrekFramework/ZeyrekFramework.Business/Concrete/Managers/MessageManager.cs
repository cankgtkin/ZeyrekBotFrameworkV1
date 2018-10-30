using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal; 
        }
        
        public Task<string> SetMessage(Message data)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Message/Create";
            url += "?SessionId=" + data.SessionId;
            url += "&ReferenceId=" + data.ReferenceId;
            url += "&ReferenceTypeId=" + data.ReferenceTypeId;
            url += "&Text=" + data.Text;
            url += "&Sender=" + data.Sender;
            url += "&SenderType=" + data.SenderType;
            url += "&CreateTime=" + data.CreateTime;
            return _messageDal.Add(baseUrl, url);
        }

        public Task<string> UpdateMessage(Message data)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Message/Edit";
            url += "?id=" + data.Id;
            url += "&SessionId=" + data.SessionId;
            url += "&ReferenceId=" + data.ReferenceId;
            url += "&ReferenceTypeId=" + data.ReferenceTypeId;
            url += "&Text=" + data.Text;
            url += "&Sender=" + data.Sender;
            url += "&SenderType=" + data.SenderType;
            url += "&CreateTime=" + data.CreateTime;
            return _messageDal.Update(baseUrl, url);
        }
    }
}
