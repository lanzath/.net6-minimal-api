using MiniTodo.Data;
using MiniTodo.ViewModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("v1/todos", (AppDbContext context) => {
    var todos = context.Todos.ToList();
    return Results.Ok(todos);
});

app.MapPost("v1/todos", (
    AppDbContext context,
    CreateTodoViewModel model) => {
        var todo = model.MapTo();
        if (!model.IsValid)
            return Results.BadRequest(model.Notifications);

        context.Todos.Add(todo);
        context.SaveChanges();

        return Results.Created($"v1/todos/{todo.Id}", todo);
    }
);

app.MapGet("v1/todos/{id}", (AppDbContext context, Guid id) => {
    var todo = context.Todos.FirstOrDefault(todo => todo.Id == id);

    if (todo != null) return Results.Ok(todo);
    return Results.NotFound();
});

app.Run();
