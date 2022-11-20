namespace MiddlewareExample
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware - Starts \n");
            await next(context);

            await context.Response.WriteAsync("Custom Middleware - Ends");
        }
    }
}
