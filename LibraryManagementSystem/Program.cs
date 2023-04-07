using LibraryManagementSystem.models;
using LibraryManagementSystem.services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddMvc();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddDbContext<LibraryManagementSystemDbContext>
    (item => item.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));
//automapper
builder.Services.AddCors(p => p.AddPolicy("MyCors", build =>
        build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyCors");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
