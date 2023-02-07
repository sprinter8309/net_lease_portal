using SearchNavigator.Data.Interfaces.Services;
using SearchNavigator.Data.Interfaces.Repositories;
using SearchNavigator.Data.Interfaces.Factories;
using SearchNavigator.Factories;
using SearchNavigator.Repositories;
using SearchNavigator.Services;
using SearchNavigator.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration["ConnectionStrings:LeaseDatabasePgsql"]));

builder.Services.AddTransient<ILeaseFactory, LeaseFactory>();
builder.Services.AddTransient<IPersonFactory, PersonFactory>();

builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<ICarRepository, CarRepository>();
builder.Services.AddTransient<ILeaseRepository, LeaseRepository>();

builder.Services.AddTransient<ICityService, CityService>();
builder.Services.AddTransient<ICarService, CarService>();
builder.Services.AddTransient<ILeaseService, LeaseService>();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Site/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Site}/{action=Index}/{id?}");

app.Run();
