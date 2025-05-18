var builder = WebApplication.CreateBuilder(args);

// Agrega los servicios necesarios para controladores (API)
builder.Services.AddControllers();

// Configura Swagger si quieres documentar/probar tu API (opcional pero útil)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware para mostrar Swagger en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirecciona HTTP a HTTPS 
app.UseHttpsRedirection();

// Configura la autorización 
app.UseAuthorization();

// Mapea los controladores
app.MapControllers();

app.Run();