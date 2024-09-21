using Microsoft.AspNetCore.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

// metodo login e senha
//post de login
app.MapPost("/login", (MinimalApi.DTOs.LoginDTO loginDTO) =>
{ // função
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso");
    }
    else
        return Results.Unauthorized();

});


app.Run();

//classe
