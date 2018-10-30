using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Session : IEntity
    {
        public virtual string Id { get; set; }
        public virtual string Platform { get; set; }
        public virtual string UserName { get; set; }
        public virtual string ConversationId { get; set; }
        public virtual int Score { get; set; }
        public virtual string StartTime { get; set; }
        public virtual string EndTime { get; set; }
        public virtual string ApplicationId { get; set; }
    }
}
