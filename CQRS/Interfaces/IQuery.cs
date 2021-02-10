using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS
{
    public interface IQuery<in TInput,out TOutput>
    {
        TOutput Execute(TInput input);

        TOutput OnException(Exception exception);
    }
}
