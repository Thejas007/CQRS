namespace CQRS.Interfaces
{
    public interface ICommandHandler
    {
        CommandResult ExecuteCommand<TInput>(TInput input);
    }
}
