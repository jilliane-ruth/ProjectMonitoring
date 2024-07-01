using Supabase;
using ProjectMonitoring.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var url = Environment.GetEnvironmentVariable("https://bacucuxysqlosdlmrqev.supabase.co");
var key = Environment.GetEnvironmentVariable("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJhY3VjdXh5c3Fsb3NkbG1ycWV2Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3MTgzMzI4MTMsImV4cCI6MjAzMzkwODgxM30.SiJmWFLYmK7ovn8bgsLMWP-ehfS5ZvfXmRouuLGHEHk");

// var options = new Supabase.SupabaseOptions
// {
//     AutoConnectRealtime = true
// };
//
// var supabase = new Supabase.Client(url, key, options);
// await supabase.InitializeAsync();

//supabase
builder.Services.AddScoped<Supabase.Client>(_ => new Supabase.Client(builder.Configuration["FunctionUrl"], builder.Configuration["AnonKey"], 
    new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true
}));

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
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "Contractor" }
);

app.MapControllerRoute(
    name: "issueReport",
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "IssueReport" }
);

app.Run();