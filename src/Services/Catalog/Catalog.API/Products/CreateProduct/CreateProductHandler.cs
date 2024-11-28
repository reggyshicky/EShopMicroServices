using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    //represents the data we need to create a product
    public record CreateProductCommand(string Name,
                                      List<string> Category,
                                      string Description,
                                      string ImageFile,
                                      decimal Price) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id); //response object/return object, in this case, we just return the id

    //contains the business logic to handle the create Product
    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create Product entity from command object
            var product = new Product()
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //TODO
            //save to db

            //return result
            return new CreateProductResult(Guid.NewGuid());

        }
    }
}
