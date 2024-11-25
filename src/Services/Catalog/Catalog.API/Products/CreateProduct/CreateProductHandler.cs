using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    //represents the data we need to create a product
    public record CreateProductCommand(string Name,
                                      List<string> Categories,
                                      string Description,
                                      string ImageFile,
                                      decimal Price) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id); //response object/return object, in this case, we just return the id

    //contains the business logic to handle the create Product
    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
