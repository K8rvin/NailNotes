using LizokasNail.Client.Repository;
using LizokasNail.Contract.Service;
using LizokasNail.Http;
using Unity;
using Unity.Lifetime;

namespace LizokasNail.Client.Di
{
    /// <summary>
    /// DI - Контейнер
    /// </summary>
    public static class Container
    {
        public static readonly IUnityContainer Instance = new UnityContainer();

        static Container()
        {
            //Instance.RegisterType<ErrorWindowPresenter>(new ContainerControlledLifetimeManager());

            /**
             * Сервисы
             */
            AsSingleton<IUserService, UserService>();
            AsSingleton<IRecordService, RecordService>();
            AsSingleton<IBaseService, BaseService>();
            AsSingleton<IColorService, ColorService>();
            AsSingleton<ITopService, TopService>();
            AsSingleton<IDesignService, DesignService>();
            AsSingleton<ICheckService, CheckService>();

            /**
             * Репозитории
             */
            AsTransient<IUserRepo, UserRepo>();
            AsTransient<IRecordRepo, RecordRepo>();
            AsTransient<IBaseRepo, BaseRepo>();
            AsTransient<IColorRepo, ColorRepo>();
            AsTransient<ITopRepo, TopRepo>();
            AsTransient<IDesignRepo, DesignRepo>();
            AsTransient<ICheckRepo, CheckRepo>();

        }

        public static void AsSingleton<TFrom, TTo>()
            where TTo : TFrom
        {
            Instance.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
        }

        /// <summary>
        /// Временная регистрация объекта.
        /// </summary>
        /// <typeparam name="TFrom">интерфейс</typeparam>
        /// <typeparam name="TTo">тип объекта-реализации</typeparam>
        public static void AsTransient<TFrom, TTo>() where TTo : TFrom
        {
            Instance.RegisterType<TFrom, TTo>();
        }
    }
}
