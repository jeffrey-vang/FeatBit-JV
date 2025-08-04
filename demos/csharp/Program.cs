using FeatBit.Sdk.Server.DependencyInjection;
using QuickRun.Workers;

var builder = WebApplication.CreateBuilder(args);

builder.Host
    .ConfigureAppConfiguration(configurationBuilder =>
    {
        configurationBuilder.AddJsonFile("appsettings.json");
    });


// FeatBit

// UI - http://localhost:8081/
// API - http://localhost:5000/
// Data Analytics - http://localhost:8200/
// Evaluation - http://localhost:5100/
// Postgres - http://localhost:5432/

// FeatBit setup - needs to be done before service configuration
builder.Services.AddFeatBit(options =>
{
    options.EnvSecret = "lB9ikUnAJ0-MRpqVCHLHdQARL0oKcXNEyYEA2zfCi2vg";
    options.StreamingUri = new Uri("ws://localhost:5100");
    options.EventUri = new Uri("http://localhost:5100");
    options.StartWaitTime = TimeSpan.FromSeconds(3);
    options.MaxEventsInQueue = 100000000;
});

builder.Services.AddHostedService<FeatBitWorker>();

var app = builder.Build();
app.Run();