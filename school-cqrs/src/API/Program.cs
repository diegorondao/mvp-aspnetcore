using Application.Services.Queries.GetCategories;
using Domain.Interfaces;
using Infrastructure.Repository;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
// builder.Services.AddMediatR(typeof(GetCategoriesQueryHandler));
 //Category
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

// --- end -- //

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

app.MapControllers();

app.Run();
