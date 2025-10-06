using CleanArchDemo.Infrastructure;
using CleanArchDemo.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Gọi Infrastructure để đăng ký DbContext + connection string
builder.Services.AddInfrastructureServices(builder.Configuration);

// Gọi Application để đăng ký MediatR, AutoMapper, v.v
builder.Services.AddApplication();

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
