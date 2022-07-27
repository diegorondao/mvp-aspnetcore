using school_estrutura.src.Infrastructure.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ping}/{action=Index}");

app.MapControllerRoute(
    name: "ping",
    pattern: "ping/abcde/teste",
    defaults: new { controller = "Ping", action = "GetByUuid" });

app.MapControllerRoute(
    name: "ping",
    pattern: "ping/all",
    defaults: new { controller = "Ping", action = "GetAll" }
);


app.Run();
