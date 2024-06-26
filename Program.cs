using Supabase;
using ProjectMonitoring.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//supabase
builder.Services.AddScoped<Supabase.Client>(_ => new Supabase.Client(builder.Configuration["SupabaseUrl"], builder.Configuration["SupabaseKey"], 
    new SupabaseOptions
{
    AutoRefreshToken = true
}));

builder.Services.AddDbContext<ProjectMonitoringDB>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Connection")));



var app = builder.Build();

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
