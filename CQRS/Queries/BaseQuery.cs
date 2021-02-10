namespace CQRS.Queries
{
    using System;

    public abstract class BaseQuery<TInput,TOutput> : IQuery<TInput, TOutput>
    {
        public abstract TOutput Execute(TInput input);

        public virtual TOutput OnException(Exception exception)
        {
            //log exception
            return default(TOutput);
        }
    }

}
