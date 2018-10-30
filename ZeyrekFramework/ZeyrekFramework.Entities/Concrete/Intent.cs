using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Intent : IEntity
    {
        public virtual string Id { get; set; }
        public virtual string ApplicationId { get; set; }
        public virtual string IntendName { get; set; }
        public virtual string CreateTime { get; set; }

    }
}
