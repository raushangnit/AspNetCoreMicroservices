using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Behaviours
{
    public interface IUnhandledExceptionBehaviour<TRequest, TResponse>
    {
        Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken);
    }
}