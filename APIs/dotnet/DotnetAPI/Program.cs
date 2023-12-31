using DotnetAPI.Data;
using DotnetAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

string connectionString = builder.Configuration.GetConnectionString("SqlLiteDb") 
    ?? throw new ArgumentNullException("SqlLiteDb is null");

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

var app = builder.Build();

app.UseCors(builder => builder    
    .WithOrigins("http://localhost:4200", "http://localhost:5160")    
    .WithMethods("POST", "PUT", "DELETE", "GET")
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.MapGet("api/employees", async (AppDbContext context) => {
    var items = await context.Employees.ToListAsync();

    return Results.Ok(items);
});

app.MapPost("api/employees", async (AppDbContext context, Employee employee) => {
    await context.Employees.AddAsync(employee);
    await context.SaveChangesAsync();

    return Results.Created($"api/employee/{employee.Id}", employee);
});

app.Run();