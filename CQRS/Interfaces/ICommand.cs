namespace CQRS
{
    using System;

    public interface ICommand<in TInput>
    {
        CommandResult Execute(TInput input);

        CommandResult OnException(Exception exception);
    }
}
