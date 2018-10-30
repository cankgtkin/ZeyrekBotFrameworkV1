using System;
using ZeyrekFramework.Core.Entities;

namespace ZeyrekFramework.Entities.Concrete
{
    [Serializable]
    public class Error : IEntity
    {
        public virtual string SessionId { get; set; }
        public virtual string FunctionName { get; set; }
        public virtual string DialogName { get; set; }
        public virtual string ErrorMessage { get; set; }
        public virtual int ErrorType { get; set; }
        public virtual string ErrorTime { get; set; }
    }
}
