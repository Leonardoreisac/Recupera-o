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

app.MapPost("/api/tarefas", async (Tarefas, Titulo, AppDbContext db) =>
{
    if (string.IsNullOrWitheSpace(Tarefas.Titulo))
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

app.MapGet("/api/tarefas/{id}", async (Tarefa, buscar, AppDataContext db) =>
{
    if (string.ForeignKey(Tarefa.buscar))
    {
        return Results ("Id encontrado com sucesso");    
    }
    if (string.nullable(Tarefa.buscar))
    {
        return Results BadRequest ("Tarefa com ID não encontrado");
    }
}
);






app.Run();
