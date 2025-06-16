using MBGestaoEscolarAN.Components;
using MBGestaoEscolarAN.Data;
using MBGestaoEscolarAN.Services.Implementations;
using MBGestaoEscolarAN.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);
//String de Conexão do SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar o DbContext com SQL Server
builder.Services.AddDbContext<SQLServerDbContext>(options =>
{
    options.UseSqlServer(connectionString);

    if (builder.Environment.IsDevelopment())
    {
        options.EnableSensitiveDataLogging();
        options.LogTo(Console.WriteLine);
    }
});

//Registrar Services de Uso
builder.Services.AddScoped<IAlunoService,AlunoService>();
builder.Services.AddScoped<ICoordenadorService, CoordenadorService>();
builder.Services.AddScoped<ICursoService, CursoService>();

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
