using RepositorypattrenwithUOW.EF;
using RepositorypattrenwithUOW.Core.Interfaces;
using RepositorypattrenwithUOW.Core;
using Microsoft.EntityFrameworkCore;
using RepositorypattrenwithUOW.EF.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddDbContext<AppDbContext>(options =>
//options.UseSqlServer(Configuration.GetConnectionString("")));
var x = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(Options => Options.UseSqlServer(x));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient(typeof (IBaseRepository<>),typeof( BaseRepository<>));
builder.Services.AddTransient<IUnitOfWork,UnitOfWork>();
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
