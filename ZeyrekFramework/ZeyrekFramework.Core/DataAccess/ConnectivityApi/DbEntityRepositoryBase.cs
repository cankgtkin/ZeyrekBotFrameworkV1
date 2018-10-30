using ZeyrekFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ZeyrekFramework.Core.DataAccess.ConnectivityApi
{
    public class DbEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : HttpClient, new()
    {
        public async Task<List<TEntity>> GetList(string baseUrl, string url)
        {
            using (var context = new TContext())
            {
                context.BaseAddress = new Uri(baseUrl);
                context.DefaultRequestHeaders.Accept.Clear();
                context.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = context.GetStringAsync(url).Result;
                var entity = JsonConvert.DeserializeObject<List<TEntity>>(response);
                return entity;
            }
        }

        public async Task<TEntity> Get(string baseUrl, string url)
        {
            using (var context = new TContext())
            {
                context.BaseAddress = new Uri(baseUrl);
                context.DefaultRequestHeaders.Accept.Clear();
                context.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = context.GetStringAsync(url).Result;
                var entity = JsonConvert.DeserializeObject<TEntity>(response);
                return entity;
            }
        }

        public async Task<string> Add(string baseUrl, string url)
        {
            var entity = string.Empty;
            var jsonString = JsonConvert.SerializeObject(entity);
            HttpContent httpContent = new StringContent(jsonString);
            using (var context = new TContext())
            {
                context.BaseAddress = new Uri(baseUrl);
                context.DefaultRequestHeaders.Accept.Clear();
                context.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await context.PutAsync(url, httpContent);
                entity = JsonConvert.DeserializeObject<string>( await response.Content.ReadAsStringAsync());
                return entity;
            }
        }

        public async Task<string> Update(string baseUrl, string url)
        {
            var entity = string.Empty;
            var jsonString = JsonConvert.SerializeObject(entity);
            HttpContent httpContent = new StringContent(jsonString);
            using (var context = new TContext())
            {
                context.BaseAddress = new Uri(baseUrl);
                context.DefaultRequestHeaders.Accept.Clear();
                context.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await context.PutAsync(url, httpContent);
                entity = JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
                return entity;
            }
        } 
    }
}
