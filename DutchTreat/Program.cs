var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(cfg =>
{
    cfg.MapControllerRoute("Default",
        "/{controller}/{action}/{id?}",
        new { controller = "App", action = "Index" });
});
app.Run();

