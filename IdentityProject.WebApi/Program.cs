using IdentityProject.WebApi.Contexts;
using IdentityProject.WebApi.Repository.Abstaracsts;
using IdentityProject.WebApi.Repository.Concrates;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MsSqlContext>();
builder.Services.AddScoped<IUserRepistory,EfUserRepository>();
builder.Services.AddScoped<IUserService,UserService>();

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
