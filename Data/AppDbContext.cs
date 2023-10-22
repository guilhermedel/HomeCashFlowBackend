using HomeCashFlowBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeCashFlowBackend.Data;
public class AppDbContext : DbContext
{
    public DbSet<CostumerModel> costumerModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    =>options.UseSqlite("DataSource=app.db;Cache=Shared");
}
