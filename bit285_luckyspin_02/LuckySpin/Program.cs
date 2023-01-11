


﻿using LuckySpin.Models;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddMvc();


//TODO: DIJ Part 1: Register the TextTranform class as available for DIJ
builder.Services.AddTransient<TextTransform>();


var app = builder.Build();


/* Middleware in the HTTP Request Pipeline
 */
app.UseStaticFiles();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Spinner/Error");
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{luck}",
    defaults: new {
        controller = "Spinner",
        action = "Index",
        luck = 7
    });

app.Run();

