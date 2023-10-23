using HomeCashFlowBackend.Controllers;
using HomeCashFlowBackend.Data;
using HomeCashFlowBackend.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/user", (AppDbContext context) =>
{
    var users = context.costumerModels.ToList();
    return Results.Ok(users);
});

app.MapPost("/user", (CostumerModel costumerModel,CostumerController costumerController, AppDbContext context) =>
{
    CostumerModel users = new CostumerModel
    {
        Name = costumerModel.Name,
        Email = costumerModel.Email,
        Cpf = costumerModel.Cpf,
        // PhoneNumber=costumerModel.PhoneNumber,
        // BirthDate=costumerModel.BirthDate,
        // Password=costumerModel.Password,
        // Balance=costumerModel.Balance
    };
    var userValidation=new CostumerController(users,context);   
    
});

app.Run();
