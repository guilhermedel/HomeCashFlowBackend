using HomeCashFlowBackend.Data;
using HomeCashFlowBackend.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/user", (AppDbContext context) => {
    var users=context.costumerModels.ToList();
    return Results.Ok(users);
});

app.MapPost("/user",(CostumerModel costumerModel)=>{

});

app.Run();
