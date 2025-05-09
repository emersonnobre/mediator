using Mediator.Abstractions;

namespace Mediator.Package;

public class Mediator(IServiceProvider serviceProvider) : IMediator
{
    public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        var handlerType = typeof(IHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
        var handler = serviceProvider.GetService(handlerType);
        if (handler == null)
            throw new InvalidOperationException($"Handler {handlerType} not found");

        var method = handlerType.GetMethod("HandleAsync");
        if (method == null)
            throw new InvalidOperationException($"Method HandleAsync for {handlerType} not found");

        var result = method.Invoke(handler, [request, cancellationToken]);
        if (result is not Task<TResponse> responseTask)
            throw new InvalidOperationException($"Handler {handlerType} returned unexpected response");

        return await responseTask;
    }
}