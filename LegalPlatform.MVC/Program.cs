using LegalPlatform.Core;
using LegalPlatform.Infrastructure;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// add layer modules
builder.Services.AddCoreModules();
builder.Services.AddServiceModules();
builder.Services.AddInfrastructureModules();

// add database
var connection = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<LegalPlatformContext>(
    option=>option.UseSqlServer(connection)
    );

// add Identity 
builder.Services.AddIdentity<LegalUser, LegalRole>().
    AddEntityFrameworkStores<LegalPlatformContext>()
    .AddDefaultTokenProviders();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/OpenLoginPage";
    });

builder.Services.AddAuthorization();
var app = builder.Build();
app.UseCors("AllowAll");

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

app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
