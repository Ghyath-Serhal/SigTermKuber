using SigTermKubernetes;

IHostBuilder builder = CreateHostBuilder(args);

await builder.RunConsoleAsync();

IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<TestBackgroundService>();
                });