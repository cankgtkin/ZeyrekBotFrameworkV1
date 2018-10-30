using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Message : IEntity
    {
        public virtual string SessionId { get; set; }
        public virtual string ReferenceId { get; set; }
        public virtual long ReferenceTypeId { get; set; }
        public virtual string Text { get; set; }
        public virtual string Sender { get; set; }
        public virtual string SenderType { get; set; }
        public virtual string CreateTime { get; set; }
        public virtual string Id { get; set; }
        public virtual DateTime Time { get; set; }
    }
}
