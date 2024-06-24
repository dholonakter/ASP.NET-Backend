using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;
using WebApplication11.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddNpgsql<PizzaContext>("DefaultConnection");
builder.Services.AddDbContext<PizzaContext>(options =>options.UseNpgsql("name=ConnectionStrings:DefaultConnection"));

//builder.addAddDbContext<PizzaContext>(options => options.UseSqlServer(Configuration.G("DefaultConnection")));
//builder.Services.AddDbContext<PizzaContext>(Options=>Options.UseNpgsql())

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
app.CreateDbIfNotExists();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
