using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class MessageSent : IEntity
    {
        public virtual string Id { get; set; }
        public virtual string ReferenceId { get; set; }
        public virtual long ReferenceTypeId { get; set; }
        public virtual string TextSent { get; set; }
        public virtual string CreateTime { get; set; }
    }
}
