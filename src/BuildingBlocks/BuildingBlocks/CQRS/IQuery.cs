using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface IQeury : IRequest<Unit>
    {

    }
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {
    }
}
