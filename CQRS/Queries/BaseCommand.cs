namespace CQRS.Queries
{
    using System;

    public abstract class BaseCommand<TInput> : ICommand<TInput>
    {
        public abstract CommandResult Execute(TInput input);

        public virtual CommandResult OnException(Exception exception)
        {
            //log exception
            return new CommandResult
            {
                Status = CommandStatus.Failed
            };
        }
    }

}
