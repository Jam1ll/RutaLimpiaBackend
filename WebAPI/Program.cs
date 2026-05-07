using Microsoft.AspNetCore.Identity;
using RutaLimpiaBackend.Core.Application;
using RutaLimpiaBackend.Infrastructure.Identity;
using RutaLimpiaBackend.Infrastructure.Identity.Entities;
using RutaLimpiaBackend.Infrastructure.Identity.Seeds;
using RutaLimpiaBackend.Infrastructure.Persistence;
using RutaLimpiaBackend.Infrastructure.Persistence.Contexts;
using RutaLimpiaBackend.Infrastructure.Shared;
using WebAPI.Extensions;
using WebAPI.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceInfrastructure(builder.Configuration);
builder.Services.AddSharedInfrastructure(builder.Configuration);
builder.Services.AddApiVersioningExtension();
builder.Services.AddIdentityInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.SetIsOriginAllowed(_ => true)
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

builder.Services.AddSignalR();

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.UseErrorHandlingMiddleware();

app.MapControllers();
app.UseStaticFiles();
app.MapHub<TrackingHub>("/trackingHub");
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var userManager = services.GetRequiredService<UserManager<User>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        await DefaultRoles.SeedAsync(roleManager);
        await DefaultAdminUser.SeedAsync(userManager);

        var applicationDbContext = services.GetRequiredService<ApplicationDbContext>();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error al insertar los datos base: {ex.Message}");
    }
}

app.Run();