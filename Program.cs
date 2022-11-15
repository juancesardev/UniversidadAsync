using Microsoft.EntityFrameworkCore;
using UniversidadAsync.Data;

var builder = WebApplication.CreateBuilder(args);


const string CONNECTIONNAME = "FuncLinq";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3. context
builder.Services.AddDbContext<FuncDBContext>(options => options.UseSqlServer(connectionString));
// Add services to the container.

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

app.MapControllers();

app.Run();
