using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CustomUserManagment.Data;
using CustomUserManagment.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CustomUserManagmentContextConnection") ?? throw new InvalidOperationException("Connection string 'CustomUserManagmentContextConnection' not found.");

builder.Services.AddDbContext<CustomUserManagmentContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CustomUserManagmentUser>(options => 
options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<CustomUserManagmentContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
