namespace CQRS.Handlers
{
    using System;
    using Interfaces;
    using Unity;

    public class QueryHandler : IQueryHandler
    {
        private readonly IUnityContainer container;

        public QueryHandler(IUnityContainer container)
        {
            this.container = container;
        }

        public TOutput ExecuteQuery<TInput, TOutput>(TInput input)
        {
            var instance = this.container.Resolve<IQuery<TInput,TOutput>>();
            try
            {
                return instance.Execute(input);
            }
            catch (Exception e)
            {
                return instance.OnException(e);
            }
        }
    }
}
