namespace Catalog.API.Products.CreateProduct
{
    //represents the data we need to create a product
    public record CreateProductCommand(string Name,
                                      List<string> Category,
                                      string Description,
                                      string ImageFile,
                                      decimal Price) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id); //response object/return object, in this case, we just return the id

    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.ImageFile).NotEmpty().WithMessage("ImageFile is required");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Category is required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }
    //contains the business logic to handle the create Product
    internal class CreateProductCommandHandler(IDocumentSession session, ILogger<CreateProductCommandHandler> logger) : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            //create Product entity from command object
            logger.LogInformation("CreateProductCommandHandler.Handle called with {@Query}", command);


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
            session.Store(product);
            await session.SaveChangesAsync(cancellationToken);

            //return result
            return new CreateProductResult(product.Id);

        }
    }
}
