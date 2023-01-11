var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<LuckySpin.Models.TextTransform>();

/* Install Services using the builder.Services methods
 */

//TODO: use the AddMvc method to enable MVC for this application

builder.Services.AddMvc();

//TODO: DIJ Part 1: Register the TextTranform class as available for DIJ


var app = builder.Build();


/* Middleware in the HTTP Request Pipeline
 */
app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Spinner/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{luck:range(1,9)}",
    defaults: new
    {
        controller = "Spinner",
        action = "Index",
        luck = 7
    });

app.Run();


