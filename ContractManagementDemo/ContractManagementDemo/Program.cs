using ContractMgmt.Application.Contract.Infrastructure.Repositories;
using ContractMgmt.Application.Contract.Infrastructure.Repositories.Interfaces;
using ContractMgmt.Application.Domain.Interfaces;
using ContractMgmt.Application.Domain.Services;
using ContractMgmt.Application.Product.Infrastructure.Repositories;
using ContractMgmt.Application.Product.Infrastructure.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IContractService, ContractService>();
builder.Services.AddScoped<IContractRepository, ContractRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
