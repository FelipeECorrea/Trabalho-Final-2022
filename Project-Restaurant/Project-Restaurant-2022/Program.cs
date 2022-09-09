using Microsoft.EntityFrameworkCore;
using Repositorio.BancoDados;
using Repositorio.InjecoesDependencia;
using Servico.InjecoesDependencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AdicionarServicos();
builder.Services.AdicionarRepositorios();
builder.Services.AddRazorPages();
builder.Services.AdicionarEntityFramework(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scopo = app.Services.CreateScope())
{
    var contexto = scopo.ServiceProvider
        .GetService<RestauranteContexto>();
    contexto.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.UseEndpoints(endpoint =>
{
    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
