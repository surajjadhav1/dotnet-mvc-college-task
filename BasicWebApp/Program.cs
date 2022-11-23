using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MetMumbaiDbContext>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
