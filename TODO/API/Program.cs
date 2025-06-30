using API.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.MapGet("/", (AppDataContext context) =>
{
    var status = context.Status.ToList();
    return Results.Ok(status);
});

app.MapPost("/api/tarefas", async (Tarefa, tarefa, AppDbContext db) =>
{
    if (string.IsNullOrWitheSpace(tarefa.Titulo))
    {
        return Results BadRequest("Título é obrigatório.");
    }
    if (string.IsNullOrWitheSpace(tarefa.status)){
        return Results BadRequest("Status é obrigatório.");
    }
}

);

app.MapGet("/api/tarefa", async (Tarefa, lista, AppDataContext db) =>
{
    if (string.ToList(Tarefa.lista))
    {
        return Results ("Lista de tarefas geradas com sucesso!");
    }
}

);






app.Run();
