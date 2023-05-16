using Microsoft.EntityFrameworkCore;
using UserDatasetLibrary.DAL;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<UserDbContext>(options =>
{
    options.UseLazyLoadingProxies(); //pokud na sobe entity zavisi aby nenacitalo obe
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
});


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
