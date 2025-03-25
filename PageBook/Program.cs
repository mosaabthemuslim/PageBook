using PageBook.Domain.Entities;
using PageBook.Infrastructure.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<PageBookDbContext>();
// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGroup("api/identity")
        .WithTags("Identity")
        .MapIdentityApi<User>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
