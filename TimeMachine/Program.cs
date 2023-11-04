using Microsoft.EntityFrameworkCore;
using TimeMachine;
using TimeMachine.Logic;
using TimeMachine.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services.AddDbContext<ITimeMachineContext, TimeMachineContext>(options =>
     options.UseSqlServer(ConfigFactory.GetConnectionString()));

builder.Services
    .AddScoped<IProjectRepository, ProjectRepository>()
    .AddScoped<ITimeLogRepository, TimeLogRepository>()
    .AddScoped<IUserRepository, UserRepository>()
    .AddScoped<ITimeMachineContext, TimeMachineContext>()
    .AddScoped<IProjectService, ProjectService>()
    .AddScoped<IUserService, UserService>()
    .AddScoped<ITimeLogService, TimeLogService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
