using API.Configurations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterDbContext(builder.Configuration.GetConnectionString("DefaultConnection")!);
builder.Services.RegisterServices();
builder.Services.RegisterRepositories();
builder.Services.AddAutoMapper(typeof(Program));

// Allow CORS from frontend
var allowedOriginPolicy = "allowedOriginPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(allowedOriginPolicy,
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseCors(allowedOriginPolicy);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
