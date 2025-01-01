﻿
using Catalog.API.Products.GetProducts;

namespace Catalog.API.Products.DeleteProduct
{
    //public record DeleteProductRequest(Guid Id)
    public record DeleteProductResponse(bool isSuccess);
    public class DeleteProductEndpoint : ICarterModule
    {
        public async void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("products/{id}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteProductCommand(id));
                var response = result.Adapt<DeleteProductResponse>();
                return Results.Ok(response);
            })
            .WithName("DeleteProducts")
            .Produces<DeleteProductResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete Products")
            .WithDescription("Delete Products");
        }
    }
}
