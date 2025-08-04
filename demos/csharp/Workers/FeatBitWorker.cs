using FeatBit.Sdk.Server;
using FeatBit.Sdk.Server.Model;

namespace QuickRun.Workers
{
    public class FeatBitWorker : BackgroundService
    {

        private readonly ILogger<FeatBitWorker> _logger;
        private readonly IFbClient fbClient;

        public FeatBitWorker(ILogger<FeatBitWorker> logger, IFbClient fbClient)
        {
            _logger = logger;
            this.fbClient = fbClient;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var lastRun = false;
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Example of using the FeatBit client
                    var user = FbUser
                        .Builder("test-user")
                        .Custom("isApi", "true")
                        .Build();
                        
                    var isOn = fbClient.BoolVariation("test", user, false);

                    if (lastRun != isOn)
                    {
                        lastRun = isOn;
                        _logger.LogInformation($"Feature 'test' is {isOn}");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred in FeatBitWorker");
                }
            }
        }
    }
}