namespace HomeCashFlowBackend.Models;

public class CostumerModel
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public int Cpf { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Password { get; set; }
    public double Balance { get; set; }
}
