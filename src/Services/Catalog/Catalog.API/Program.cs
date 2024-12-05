var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

//Add Services to the container
var app = builder.Build();

//configure the HTTP request pipeline
app.MapCarter();
app.Run();
