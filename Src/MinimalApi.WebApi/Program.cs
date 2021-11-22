using MinimalApi.Application.Interfaces;
using MinimalApi.Application.Implementations;
using MinimalApi.Infrastructure.Implementations;
using MinimalApi.Domain.Dto;
using MinimalApi.Domain.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IToDoService, ToDoService>();
builder.Services.AddScoped<IToDoRepository, ToDoRepository>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/todos", async (IToDoService service) =>
{
    try
    {
        var todoList = await service.GetItems();
        if (todoList.Count == 0 || todoList == null)
        {
            return Results.NotFound();
        }
        return Results.Ok(todoList);
    }
    catch (Exception e)
    {
        return Results.Problem();
    }

}).WithName("GetALlTodo");

app.MapGet("/todos/{id}", async (IToDoService service, Guid id) =>
{
    try
    {
        var todo = await service.GetItem(id);
        if (todo == null)
        {
            return Results.NotFound();
        }
        return Results.Ok(todo);
    }
    catch (Exception e)
    {
        return Results.Problem();
    }

}).WithName("GetTodoById");


app.MapPost("/todos", async (IToDoService service, ToDoInputDto item) =>
{
    try
    {
        var todo = await service.Add(item);
        return Results.CreatedAtRoute("GetTodoById", new { Id = todo.Id }, todo);
    }
    catch (global::System.Exception)
    {
        return Results.Problem();
    }
    
}).WithName("AddTodo");


app.Run();
