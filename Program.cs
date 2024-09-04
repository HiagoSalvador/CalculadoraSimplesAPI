var builder = WebApplication.CreateBuilder(args);

// adds  services
builder.Services.AddControllers(); // support for controllers

// adds api endpoint
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// configures 
if (app.Environment.IsDevelopment())
{
    // enables swagger and swagger 
    app.UseSwagger();
    app.UseSwaggerUI();
}

// adds https redirection
app.UseHttpsRedirection();

// enables routing for controllers
app.UseAuthorization();

// maps api endpoints
app.MapControllers(); 

// start app
app.Run();