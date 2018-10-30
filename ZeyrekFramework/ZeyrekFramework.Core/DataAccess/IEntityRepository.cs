using ZeyrekFramework.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ZeyrekFramework.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetList(string baseUrl, string url);

        Task<T> Get(string baseUrl, string url);

        Task<string> Add(string baseUrl, string url);

        Task<string> Update(string baseUrl, string url);
    }
}
