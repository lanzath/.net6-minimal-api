var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    // Instancia um novo record de Todo.
    var todo = new Todo(Guid.NewGuid(), "Estudar .NET 6", true);

    // Devolve resposta em Json com status 200.
    return Results.Ok(todo);
});

app.Run();
