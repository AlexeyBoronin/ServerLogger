using WebApplication1;

var builder = WebApplication.CreateBuilder();
// устанавливаем файл для логгирования
builder.Logging.AddFile(Path.Combine(Directory.GetCurrentDirectory(), "logger.txt"));
// настройка логгирования с помошью свойства Logging идет до 
// создания объекта WebApplication
var app = builder.Build();

app.Run(async (context) =>
{
    app.Logger.LogInformation($"Path: {context.Request.Path}  Time:{DateTime.Now.ToLongTimeString()}");
    await context.Response.WriteAsync("Hello World!");
});

app.Run();