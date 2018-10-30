using System.Configuration;
using System.Threading.Tasks;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Concrete.Managers
{
    public class SessionManager : ISessionService
    {
        private readonly ISessionDal _sessionDal;

        public SessionManager(ISessionDal sessionDal)
        {
            _sessionDal = sessionDal; 
        }

        public Task<string> SetSession(Session data)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Session/Create";
            url += "?Platform=" + data.Platform;
            url += "&UserName=" + data.UserName;
            url += "&ConversationId=" + data.ConversationId;
            url += "&Score=" + data.Score;
            url += "&StartTime=" + data.StartTime;
            url += "&EndTime=" + data.EndTime;
            url += "&ApplicationId=" + data.ApplicationId;
            return _sessionDal.Add(baseUrl, url);
        }

        public Task<string> UpdateSession(Session data)
        {
            var baseUrl = ConfigurationManager.AppSettings["ZeyrekConnectivityApi"];
            var url = "Session/Edit";
            url += "?id=" + data.Id;
            url += "&Platform=" + data.Platform;
            url += "&UserName=" + data.UserName;
            url += "&ConversationId=" + data.ConversationId;
            url += "&Score=" + data.Score;
            url += "&StartTime=" + data.StartTime;
            url += "&EndTime=" + data.EndTime;
            url += "&ApplicationId=" + data.ApplicationId;
            return _sessionDal.Update(baseUrl, url);
        }
    }
}
