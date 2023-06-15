using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ruisoArtPage.Data;
using ruisoArtPage.Models;
using ruisoArtPage.Data.Static;
using ruisoArtPage.Data.Enum;
using ruisoArtPage.Data.ViewModels;
using ruisoArtPage.Data.Cart;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    //options.UseSqlite(connectionString)
    options.UseMySql(
        connectionString,
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql")
    )
);

// agregado con scallfolding
//builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();

//NEW shopping cart
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));
builder.Services.AddSession();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//Builder EntityFramework
/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
   .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();*/

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => {
    options.SignIn.RequireConfirmedAccount = true;
}).AddEntityFrameworkStores<ApplicationDbContext>().AddRoles<IdentityRole>().AddDefaultUI();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()){
    app.UseMigrationsEndPoint();
}
else{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//NEW shopping cart
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //pattern: "{controller=Product}/{action=Index}/{id?}");
app.MapRazorPages();

var seeding = new AppDbInitializer();//Datos de semilla de inicio si no hay nada en la base de datos
seeding.Seed(app); //Datos de semilla de inicio si no hay nada en la base de datos
AppDbInitializer.SeedUserAndRolesAsync(app).Wait();

app.Run();


//new
/*
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
 options.Stores.MaxLengthForKeys = 128;
 options.SignIn.RequireConfirmedAccount= true;
}).AddEntityFrameworkStores<ApplicationDbContext>()
.AddRoles<IdentityRole>()
.AddDefaultUI()
.AddDefaultTokenProviders();
*/


/*
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Movie}/{action=Index}/{id?}");
app.MapRazorPages();
AppDbInitializer.Seed(app);
AppDbInitializer.SeedUserAndRolesAsync(app).Wait();
app.Run();

*/


