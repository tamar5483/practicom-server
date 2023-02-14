using MyProject.MyServices;
using MyProject.MyServices.Interfaces;
using MyProject.MyServices.Services;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using static MyProject.Context.MyContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt => opt.AddPolicy("PolicyName", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

builder.Services.AddScoped<IContext, MyDbContex>();
builder.Services.AddAutoMapper(typeof(Mapping));

builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("PolicyName");

app.UseAuthorization();

app.MapControllers();

app.Run();
