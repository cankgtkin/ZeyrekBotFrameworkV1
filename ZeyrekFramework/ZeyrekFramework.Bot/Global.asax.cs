using System.Web.Http;
using Autofac;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.Business.Concrete.Managers;
using ZeyrekFramework.Business.DependencyResolvers.Autofac;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.DataAccess.Concrete.ConnectivityApi;

namespace ZeyrekFramework.Bot
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var builder = new ContainerBuilder();

            builder.RegisterType<ApplicationManager>().As<IApplicationService>().SingleInstance();
            builder.RegisterType<DbApplicationDal>().As<IApplicationDal>().SingleInstance();
            
            builder.RegisterType<ErrorManager>().As<IErrorService>().SingleInstance(); 
            builder.RegisterType<DbErrorDal>().As<IErrorDal>().SingleInstance();
            
            builder.RegisterType<IntentManager>().As<IIntentService>().SingleInstance(); 
            builder.RegisterType<DbIntentDal>().As<IIntentDal>().SingleInstance();
            
            builder.RegisterType<MessageManager>().As<IMessageService>().SingleInstance(); 
            builder.RegisterType<DbMessageDal>().As<IMessageDal>().SingleInstance(); 

            builder.RegisterType<MessageSentManager>().As<IMessageSentService>().SingleInstance(); 
            builder.RegisterType<DbMessageSentDal>().As<IMessageSentDal>().SingleInstance();
            
            builder.RegisterType<SessionManager>().As<ISessionService>().SingleInstance(); 
            builder.RegisterType<DbSessionDal>().As<ISessionDal>().SingleInstance();
            
            builder.RegisterType<ParameterManager>().As<IParameterService>().SingleInstance(); 
            builder.RegisterType<DbParameterDal>().As<IParameterDal>().SingleInstance(); ;

            var container = builder.Build();

            IocServiceResolver.Container = container;
        } 
    }
}
