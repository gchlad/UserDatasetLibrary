// dotnet ef  migrations add --verbose --project UserDatasetLibrary.DAL\UserDatasetLibrary.DAL.csproj --startup-project UserDatasetLibrary\UserDatasetLibrary.WebApp.csproj initMigration

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
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<UserDbContext>();
    db.Database.Migrate();
}

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
