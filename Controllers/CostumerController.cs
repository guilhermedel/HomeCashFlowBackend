using System.Text.RegularExpressions;
using HomeCashFlowBackend.Data;
using HomeCashFlowBackend.Models;

namespace HomeCashFlowBackend.Controllers;
public class CostumerController
{
    private CostumerModel User { get; set; }
    private AppDbContext Context { get; set; }
    public CostumerController(CostumerModel user, AppDbContext context)
    {
        User = user;
        Context = context;
    }
    public bool EmailIsValid()
    {
        string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        if (Regex.IsMatch(User.Email, pattern))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool UserIsLogged()
    {
        if (Context.costumerModels.FirstOrDefault(x => x.Cpf == User.Cpf) != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}