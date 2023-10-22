using DotnetAPI.Data;
using DotnetAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("SqlLiteDb") 
    ?? throw new ArgumentNullException("SqlLiteDb is null");

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

var app = builder.Build();

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