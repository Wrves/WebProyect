var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers(); 

builder.Services.AddAuthorization();
var app = builder.Build();

app.UseCors("AllowAngularApp");
app.UseAuthorization();

app.MapControllers();

app.Run();
