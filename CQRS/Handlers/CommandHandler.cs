namespace CQRS.Handlers
{
    using System;
    using Interfaces;
    using Unity;

    public class CommandHandler : ICommandHandler
    {
        private readonly IUnityContainer container;

        public CommandHandler(IUnityContainer container)
        {
            this.container = container;
        }

        public CommandResult ExecuteCommand<TInput>(TInput input)
        {
            var instance = this.container.Resolve<ICommand<TInput>>();
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
