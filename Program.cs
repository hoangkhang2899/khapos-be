using KhaPOS_BE.Data;
using KhaPOS_BE.Interfaces;
using KhaPOS_BE.Models;
using KhaPOS_BE.Services;

using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Microsoft.EntityFrameworkCore;

using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(o =>
{
    o.ModelMetadataDetailsProviders.Add(new NewtonsoftJsonValidationMetadataProvider());
}).AddNewtonsoftJson(o =>
{
    // o.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IToppingService, ToppingService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();

builder.Services.AddAutoMapper(
    typeof(TransactionMappingProfile),
    typeof(ToppingMappingProfile)
);

builder.Services.AddDbContext<Context>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

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

app.MapSwagger().RequireAuthorization();

app.Run();