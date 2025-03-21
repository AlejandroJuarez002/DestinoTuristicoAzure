using ExploreSV.BusinessLogic;
using ExploreSV.BusinessLogic.UseCases.Users.Queries.UserAuthentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddBusinessLogicServices(builder.Configuration);

var app = builder.Build();

// Agregar soporte para sesiones
builder.Services.AddDistributedMemoryCache(); // Necesario para almacenar las sesiones en memoria
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Esto hace que la cookie sea esencial para la aplicación
});

// Agregar el caso de uso para Login
builder.Services.AddScoped<UserAuthentication>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
