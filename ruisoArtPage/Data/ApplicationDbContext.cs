using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Models;

namespace ruisoArtPage.Data;

//public class ApplicationDbContext : IdentityDbContext
public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
    protected override void OnModelCreating(ModelBuilder builder){
        base.OnModelCreating(builder);
    }
    public DbSet<Banner> Banner { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<CategoryCommi> CategoryCommi { get; set; }
    public DbSet<CategoryProduct> CategoryProduct { get; set; }
    public DbSet<Commission> Commission { get; set; }
    public DbSet<DocProduct> DocProduct { get; set; }
    public DbSet<Document> Document { get; set; }

    // public DbSet<Item> Item { get; set; }

    public DbSet<Product> Product { get; set; }
    public DbSet<Provider> Provider { get; set; }

    // public DbSet<MyType> MyType { get; set; }

    public DbSet<DocCommi> DocCommi { get; set; }
    public DbSet<ApplicationUser> ApplicationUser { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderItem> OrderItem { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }

}
