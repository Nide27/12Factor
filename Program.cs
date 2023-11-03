using WeatherAPI;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration;
string connection = configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<WeatherContext>(options =>
    options.UseNpgsql(connection));

var dataSourceBuilder = new NpgsqlDataSourceBuilder(connection);

await using var dataSource = dataSourceBuilder.Build();
string dbName = configuration.GetValue<string>("dbName");

await using var command = dataSource.CreateCommand($"CREATE TABLE IF NOT EXISTS {dbName} (id SERIAL PRIMARY KEY, location VARCHAR(255) NOT NULL, temperature VARCHAR(50) NOT NULL);");
await using var reader = await command.ExecuteReaderAsync();

while (await reader.ReadAsync())
{
    Console.WriteLine(reader.GetString(0));
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();


app.Run();