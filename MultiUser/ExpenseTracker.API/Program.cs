using ExpenseTracker.Core;
using ExpenseTracker.Core.Services;
using ExpenseTracker.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.Configure<TenantSettings>(builder.Configuration.GetSection(nameof(TenantSettings)));
builder.Services.AddTransient<ITenantService,TenantService>();
builder.Services.AddAndMigrateDatabases(builder.Configuration);
builder.Services.AddTransient<IHabitService, HabitService>();


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
