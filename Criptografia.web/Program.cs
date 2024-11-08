using Criptografia.web.Configuration;

var builder = WebApplication.CreateBuilder(args);
{
    builder.AddMvcConfiguration();

    var services = builder.Services;


   services.AddControllersWithViews().AddRazorRuntimeCompilation();
    services.AddHttpContextAccessor();
    services.AddHttpClient();
}



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
