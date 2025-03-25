using ExploreSV.BusinessLogic;
using ExploreSV.BusinessLogic.UseCases.Users.Queries.UserAuthentication;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Agregar soporte para sesiones
builder.Services.AddDistributedMemoryCache(); // Necesario para almacenar las sesiones en memoria
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // Esto hace que la cookie sea esencial para la aplicación
});

// Agregar lógica de negocio
builder.Services.AddBusinessLogicServices(builder.Configuration);

// Agregar el caso de uso para Login
builder.Services.AddScoped<UserAuthentication>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Usar sesiones antes de routing
app.UseSession(); // Esta línea es importante para habilitar el uso de sesiones

app.UseRouting();
app.UseAuthorization();

// Configurar las rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

