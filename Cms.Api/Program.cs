using Cms.Core;
using Cms.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureDataServices(builder.Configuration);
builder.Services.ConfigurationApplicationService();

//builder.Services.AddScoped<IPostRepository, PostRepository>();
//builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
