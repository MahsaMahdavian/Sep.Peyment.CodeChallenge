using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Payments.Domain.Common;
using Payments.Domain.InfrustructureService;
using Payments.Infrastructure;
using Payments.Infrastructure.banksProvider;
using Payments.PaymentApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Defult"));
});

builder.RegisterHTTPClient<Saman>((p, client) =>
{
    var options = p.GetRequiredService<IOptions<UrlOption>>();
    client.BaseAddress = options.Value.SamanUrl;
});
builder.RegisterHTTPClient<Mellat>((p, client) =>
{
    var options = p.GetRequiredService<IOptions<UrlOption>>();
    client.BaseAddress = options.Value.MellatUrl;
});
builder.RegisterHTTPClient<Ayande>((p, client) =>
{
    var options = p.GetRequiredService<IOptions<UrlOption>>();
    client.BaseAddress = options.Value.AyandeUrl;
});

builder.AddApplication();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapPost("send-to-peyment", Endpoints.SendToPayment);
app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}