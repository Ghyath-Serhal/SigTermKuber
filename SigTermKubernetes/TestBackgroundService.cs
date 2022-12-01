using System.Runtime.InteropServices;

namespace SigTermKubernetes
{
    public class TestBackgroundService : IHostedService
    {
        IHostApplicationLifetime _applicationLifetime;

        public TestBackgroundService(IHostApplicationLifetime applicationLifetime)
        {
            _applicationLifetime = applicationLifetime;
        }

        private void OnApplicationStopping()
        {
            Console.WriteLine("In the OnApplicationStopping");
        }

        private void OnApplicationStopped()
        {
            Console.WriteLine("In the OnApplicationStopped");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _applicationLifetime.ApplicationStopping.Register(OnApplicationStopping);
            _applicationLifetime.ApplicationStopped.Register(OnApplicationStopped);

            Console.WriteLine("In the StartAsync of TestBackgroundService");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("In the StartAsync of TestBackgroundService");
            return Task.CompletedTask;
        }
    }
}
