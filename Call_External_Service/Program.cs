using Call_External_Service.Clients.ClassUp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IClassUpClient, ClassUpClient>();
builder.Services.AddHttpClient("ClassUp", client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ClassUp:BaseUrl")!);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
