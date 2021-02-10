namespace CQRS.Interfaces
{
    public interface IQueryHandler
    {
        TOutput ExecuteQuery<TInput, TOutput>(TInput input);
    }
}
