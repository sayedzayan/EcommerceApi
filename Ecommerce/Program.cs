using Ecommerce.BusinessLogic.Managers.Abstracts;
using Ecommerce.BusinessLogic.Managers.Implementations;
using Ecommerce.Domain.Data;
using Ecommerce.Domain.Repositories.Abstracts;
using Ecommerce.Domain.Repositories.implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("Ecommerce");
builder.Services.AddDbContext<EcommerceDbContext>(options =>
options.UseSqlServer(connectionString));


#region

builder.Services.AddScoped<ICategoryRepository , CategoryRepository>();

#endregion

#region Managers

builder.Services.AddScoped<ICategoryManager, CategoryManager>();  

#endregion

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
