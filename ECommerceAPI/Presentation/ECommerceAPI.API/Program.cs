using ECommerceAPI.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceServices();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Bunu ekle
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "ECommerce API v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
