using TMS.Application;
using TMS.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// DI for services and repositories
builder.Services.AddInfrastructure("Server=db47596.public.databaseasp.net,1433;Initial Catalog=db47596;Persist Security Info=False;User ID=db47596;Password=2e#MW6n-7i%Q;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
builder.Services.AddApplication();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// APIs general settings
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();