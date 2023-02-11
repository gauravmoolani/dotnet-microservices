using Microsoft.EntityFrameworkCore;
using Restro.Services.ProductAPI.Models;
using System;

namespace Restro.Services.ProductAPI.DbContexts;
public class ApplicationDbContext:DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
	{

	}
	public DbSet<Product> Products { get; set; }
}
