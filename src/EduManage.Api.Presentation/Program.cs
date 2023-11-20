using EduManage.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Diagnostics;
using EduManage.Api.Application.Interfaces;
using EduManage.Api.Application.Services;
using EduManage.Api.Infrastructure.Utils;
using EduManage.Api.Infrastructure.Services;
using EduManage.Api.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "EduManage.Api", Version = "v1" });

    // Configure Swagger to use the "Authorize" button
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        });
});

builder.Services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
{
    var redisCacheService = serviceProvider.GetRequiredService<IRedisCacheService>();
    options.UseNpgsql(
        "Host=localhost;Database=EduManage;Username=root;Password=root",
        npgsqlOptions => npgsqlOptions.MigrationsAssembly("EduManage.Api.Infrastructure")
    )
    .AddInterceptors(serviceProvider.GetRequiredService<RedisCacheInterceptor>());
});

builder.Services.AddSingleton<IRedisCacheService, RedisCacheService>();
builder.Services.AddScoped<RedisCacheInterceptor>();

// Configure authentication to use IdentityServer
builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.Authority = "https://localhost:5001";
        options.RequireHttpsMetadata = false; // should be true in production
        options.Audience = "EduManage.Api";

        // Optional: Explicitly set token validation parameters
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your-256-bit-secret")),
            ValidateIssuer = true,
            ValidIssuer = "https://localhost:5001",
            ValidateAudience = true,
            ValidAudience = "EduManage.Api",
        };
    });

IdentityModelEventSource.ShowPII = true;

builder.Services.AddApplicationServices();
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

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
