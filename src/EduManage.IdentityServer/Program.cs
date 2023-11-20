using EduManage.Api.Domain;
using EduManage.Api.Domain.Interfaces;
using EduManage.Api.Infrastructure.Data;
using EduManage.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql("Host=localhost;Database=EduManage;Username=root;Password=root"));


builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

builder.Services.AddIdentityServer()
        .AddAspNetIdentity<ApplicationUser>()
        // Uncomment and configure these lines:
        .AddConfigurationStore(options =>
        {
            options.ConfigureDbContext = b =>
                b.UseNpgsql("Host=localhost;Database=EduManage;Username=root;Password=root",
                    sql => sql.MigrationsAssembly("EduManage.Api.Infrastructure"));
        })
        .AddOperationalStore(options =>
        {
            options.ConfigureDbContext = b =>
                b.UseNpgsql("Host=localhost;Database=EduManage;Username=root;Password=root",
                    sql => sql.MigrationsAssembly("EduManage.Api.Infrastructure"));
        })
        .AddDeveloperSigningCredential();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();