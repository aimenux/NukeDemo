using Lib;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace App
{
    public class DummyHostedService : IHostedService
    {
        private readonly IDummyService _dummyService;
        private readonly ILogger _logger;

        public DummyHostedService(IDummyService dummyService, ILogger logger)
        {
            _dummyService = dummyService;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var message = _dummyService.GetStartingMessage();
            _logger.LogInformation(message);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            var message = _dummyService.GetStoppingMessage();
            _logger.LogInformation(message);
            return Task.CompletedTask;
        }
    }
}
