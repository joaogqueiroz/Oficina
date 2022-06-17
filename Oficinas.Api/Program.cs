using MediatR;
using Microsoft.EntityFrameworkCore;
using Oficinas.Application.Commands.CreateOficina;
using Oficinas.Core.Repostories;
using Oficinas.Infrastructure.Persistence;
using Oficinas.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("OficinaCs");
builder.Services.AddDbContext<OficinaDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IOficinaRepository, OficinaRepository>();
builder.Services.AddScoped<IServicoRepository, ServicoRepository>();
builder.Services.AddScoped<IAgendamentoRepository, AgendamentoRepository>();

builder.Services.AddControllers();
builder.Services.AddMediatR(typeof(CreateOficinaCommand));

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
