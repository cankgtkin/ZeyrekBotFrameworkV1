using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Application : IEntity
    {
        public virtual string Id { get; set; }
        public virtual string ApplicationName { get; set; }
        public virtual string CreateTime { get; set; }


    }
}
