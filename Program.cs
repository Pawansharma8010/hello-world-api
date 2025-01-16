var builder = WebApplication.CreateBuilder(args);

// Add services to the container (optional for Hello World, can be removed if not needed).
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

// Define a "Hello World" endpoint.
app.MapGet("/hello", () => "Hello World!")
   .WithName("GetHelloWorld")
   .WithOpenApi();

// Run the application.
app.Run();

