using LegalPlatform.Core;
using LegalPlatform.Infrastructure;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// add app moudles 
builder.Services.AddInfrastructureModules();
builder.Services.AddCoreModules();
builder.Services.AddServiceModules();


builder.Services.AddIdentity<LegalUser, LegalRole>().
    AddEntityFrameworkStores<LegalPlatformContext>()
    .AddDefaultTokenProviders();

// add database 
var connectionString = builder.Configuration.GetConnectionString("ConnectionString");
builder.Services.AddDbContext<LegalPlatformContext>
    (options=>options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
