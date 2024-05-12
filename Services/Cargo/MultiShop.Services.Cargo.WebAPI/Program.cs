using Microsoft.AspNetCore.Authentication.JwtBearer;
using MultiShop.Services.Cargo.BusinessLayer.Abstract;
using MultiShop.Services.Cargo.BusinessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.Abstract;
using MultiShop.Services.Cargo.DataAccessLayer.Concrete;
using MultiShop.Services.Cargo.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "ResourceCargo";
    opt.RequireHttpsMetadata = false;
});

builder.Services.AddDbContext<CargoContext>();

builder.Services.AddScoped<ICargoCompanyDAL, EFCargoCompanyDAL>();
builder.Services.AddScoped<ICargoCompanyService, CargoCompanyManager>();
builder.Services.AddScoped<ICargoCustomerDAL, EFCargoCustomerDAL>();
builder.Services.AddScoped<ICargoCustomerService, CargoCustomerManager>();
builder.Services.AddScoped<ICargoDetailDAL, EFCargoDetailDAL>();
builder.Services.AddScoped<ICargoDetailService, CargoDetailManager>();
builder.Services.AddScoped<ICargoOperationDAL, EFCargoOperationDAL>();
builder.Services.AddScoped<ICargoOperationService, CargoOperationManager>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
