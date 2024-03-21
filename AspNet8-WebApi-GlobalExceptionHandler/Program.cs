using AspNet8_WebApi_GlobalExceptionHandler.Exceptions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

app.MapControllers();

app.UseExceptionHandler();

app.Run();