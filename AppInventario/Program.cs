using AppInventario.Components;
using AppInventario.Services;
using AppInventario.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using AppInventario.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

    //implementações

builder.Services.AddScoped<PessoaService>();
builder.Services.AddScoped<PropriedadeService>();

// conexão com BD
string mySqlConexao = builder.Configuration.GetConnectionString("BaseConexaoMySql");
builder.Services.AddDbContextPool<ContextoBD>(options =>
options.UseMySql(mySqlConexao, ServerVersion.AutoDetect(mySqlConexao)));

builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
options.UseMySql(mySqlConexao, ServerVersion.AutoDetect(mySqlConexao)));




builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
