using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Parameter : IEntity
    {
        public virtual string Id { get; set; }
        public virtual string IntendId { get; set; }
        public virtual long ParameterTypeId { get; set; }
        public virtual string ParameterName { get; set; }
        public virtual string CreateTime { get; set; }

    }
}
