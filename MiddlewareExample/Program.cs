var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello \n");
    await next(context);
});

//Middleware 2
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello1 \n");
    await next(context);
});

//Middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello2");
});

app.Run();
