using Ninject.Modules;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.Business.Concrete.Managers;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.DataAccess.Concrete.ConnectivityApi;

namespace ZeyrekFramework.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationService>().To<ApplicationManager>().InSingletonScope();
            Bind<IApplicationDal>().To<DbApplicationDal>().InSingletonScope();

            Bind<IErrorService>().To<ErrorManager>().InSingletonScope();
            Bind<IErrorDal>().To<DbErrorDal>().InSingletonScope();

            Bind<IIntentService>().To<IntentManager>().InSingletonScope();
            Bind<IIntentDal>().To<DbIntentDal>().InSingletonScope();

            Bind<IMessageService>().To<MessageManager>().InSingletonScope();
            Bind<IMessageDal>().To<DbMessageDal>().InSingletonScope();

            Bind<IMessageSentService>().To<MessageSentManager>().InSingletonScope();
            Bind<IMessageSentDal>().To<DbMessageSentDal>().InSingletonScope();

            Bind<ISessionService>().To<SessionManager>().InSingletonScope();
            Bind<ISessionDal>().To<DbSessionDal>().InSingletonScope();

            Bind<IParameterService>().To<ParameterManager>().InSingletonScope();
            Bind<IParameterDal>().To<DbParameterDal>().InSingletonScope();
        }
    }
}
