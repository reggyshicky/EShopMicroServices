
namespace Catalog.API.Products.DeleteProduct
{
    public record DeleteProductCommand(Guid Id) : ICommand<DeleteProductResult>;

    public record DeleteProductResult(bool isSuccess);

    public class DeleteProductResultValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductResultValidator()
        {
            RuleFor(command => command.Id).NotEmpty().WithMessage("Id is required");
        }
    }



    internal class DeleteProductCommandHandler
        (IDocumentSession session, ILogger<DeleteProductCommandHandler> logger)
        : ICommandHandler<DeleteProductCommand, DeleteProductResult>
    {
        public async Task<DeleteProductResult> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            logger.LogInformation("DeleteProductsCommandHandler.Handle called with {@Query}", command);

            session.Delete<Product>(command.Id);
            await session.SaveChangesAsync(cancellationToken);

            return new DeleteProductResult(true);

        }
    }
}
