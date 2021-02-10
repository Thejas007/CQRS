namespace CQRS
{
    using Handlers;
    using Interfaces;
    using Queries;
    using Unity;

    public static class UnityConfig
    {

        private static readonly IUnityContainer unityContainer = new UnityContainer();

        /// <summary>
        /// Gets the IUnityContainer
        /// </summary>
        public static IUnityContainer UnityContainer
        {
            get
            {
                return unityContainer;
            }
        }


        public static void Register()
        {
            UnityContainer.RegisterType<IQuery<ProductIdRequest, ProductEntity>, ProductQuery>();
            UnityContainer.RegisterType<IQueryHandler, QueryHandler>();
        }
    }
}
