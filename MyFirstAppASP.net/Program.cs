using System.Diagnostics.CodeAnalysis;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(async (context) =>
{
    var path = context.Request.Path;
    var response = context.Response;
    
    if(path == "/date")
    {
        await response.WriteAsync($"Date: {DateTime.Now.ToShortDateString()}");
    }
    else if (path =="/time")
    {
        await response.WriteAsync($"Time: {DateTime.Now.ToShortTimeString()}");
    }
    else
    {
        await response.WriteAsync("Welcome to my app");
    }


});
app.Run();
