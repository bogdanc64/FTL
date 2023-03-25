using Microsoft.EntityFrameworkCore;
using Traveloo.Sql.Library;
using Traveloo.Sql.Library.Services;

var builder = WebApplication.CreateBuilder(args);

#pragma warning disable CS8600
string dbConnectionString = builder.Configuration.GetConnectionString("DbConnectionString");
#pragma warning restore CS8600

builder.Services.AddDbContext<Traveloo.Sql.Library.DbContext>(
    options => options.UseSqlServer(dbConnectionString));
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<ApplicationUserService>();
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
