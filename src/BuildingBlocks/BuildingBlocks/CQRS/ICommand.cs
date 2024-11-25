using MediatR;

namespace BuildingBlocks.CQRS
{
    //Does not produce a response
    public interface ICommand : ICommand<Unit>
    {

    }

    //Produces a response
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {

    }
}
