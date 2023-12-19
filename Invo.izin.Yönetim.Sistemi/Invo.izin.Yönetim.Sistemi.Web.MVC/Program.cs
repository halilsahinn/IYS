using Invo.izin.Yönetim.Sistemi.Web.MVC.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvcCore();
//builder.Services.AddRazorPages();
// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

#region CUSTOM MIDDLEWARE - > EXCEPTION
app.UseMiddleware<ExceptionMiddleware>();
#endregion


app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Home";
        await next();
    }
});

 
 
app.UseEndpoints(endpoints =>
{


    endpoints.MapAreaControllerRoute(
        name: "secure",
        areaName: "secure",
        pattern: "{areas=secure}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapDefaultControllerRoute();
});

app.Run();
