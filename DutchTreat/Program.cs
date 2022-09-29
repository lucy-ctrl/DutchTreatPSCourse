using DutchTreat.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddTransient<IMailService,NullMailService>(); //service we're gonna inject and the class(type) which implements this for me
//builder.Services.AddRunTimeCompilation();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(cfg =>
{
    cfg.MapRazorPages();
    cfg.MapControllerRoute("Default",
        "/{controller}/{action}/{id?}",
        new { controller = "App", action = "Index" });
});
app.Run();

