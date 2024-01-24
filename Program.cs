using minimal_api.Domain.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDto) =>
{
    if (loginDto.Email == "adm@teste.com" && loginDto.Password == "123456")
        return Results.Ok("Login realizado com sucesso!");
    else
        return Results.Unauthorized();
});

app.Run();
