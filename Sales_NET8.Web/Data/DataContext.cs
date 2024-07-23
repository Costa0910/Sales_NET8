using Microsoft.EntityFrameworkCore;
using Sales_NET8.Web.Data.Entities;

namespace Sales_NET8.Web.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Country> Countries { set; get; }
}