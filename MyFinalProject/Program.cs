using Microsoft.EntityFrameworkCore;
using MyFinalProject.Data;
using MyFinalProject.Repositiories;
using Microsoft.AspNetCore.Identity;
using MyFinalProject.Areas.Identity.Data;
using MyFinalProject.Models;
using MyFinalProject.Models.VMs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Repositiorites Register
builder.Services.AddScoped<ICategoryRep, CategoryRep>();

//Repositiorities Register
builder.Services.AddScoped<IUserRep, UserRep>();
builder.Services.AddScoped<IProductRep, ProductRep>();
builder.Services.AddSingleton<List<OrderVM>>();


//ApplicationDbContext Regiter DbSet Register
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("default")));

builder.Services.AddDefaultIdentity<ProjectUser>()
	.AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.MapRazorPages();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=main}/{id?}");
app.Run();
