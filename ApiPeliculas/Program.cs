using ApiPeliculas.Data;
using ApiPeliculas.Repositorio.IRepositorio;
using ApiPeliculas.Repositorio;
using Microsoft.EntityFrameworkCore;
using ApiPeliculas.PeliculasMapper;

var builder = WebApplication.CreateBuilder(args);

//Configurar la conexion a SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSql"));
});


//Agregamos los repositorios
builder.Services.AddScoped<ICategoriaRepositorio, CategoriaRepositorio>();
builder.Services.AddScoped<IPeliculaRepositorio, PeliculaRepositorio>();

//Agregar el AutoMapper
builder.Services.AddAutoMapper(typeof(PeliculasMapper));


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
