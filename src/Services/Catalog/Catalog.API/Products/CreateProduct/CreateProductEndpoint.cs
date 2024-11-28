using Carter;
using Mapster;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductRequest(string Name,
                                List<string> Category,
                                string Description,
                                string ImageFile,
                                decimal Price);

    public record CreateProductResponse(Guid Id);

    public class CreateProductEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/product", async (CreateProductRequest request, ISender sender) =>
            {
                var command = request.Adapt<CreateProductCommand>();

                var result = await sender.Send(command);

                var response = result.Adapt<CreateProductResponse>();

                return Results.Created($"/products{response.Id}", response);
            });
        }
    }
}

//Carter library for minimal API endpoint Definition
//Carter is a library that extends the capabilities of ASP.Net Core's minimal APIs
//Provides a more structured way to organize our endpoints and simplifies the creation of HTTP request handlers
//Carter is a framework that is a thin layer extension methods and functionality over ASP.Net Core
