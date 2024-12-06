using Microsoft.Extensions.Hosting;

public class BackgroundTasks : BackgroundService
{
    private readonly IServiceProvider _provider;

    public BackgroundTasks(IServiceProvider provider) => _provider = provider;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _provider.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<NotificationService>();
                service.CheckNotifications();
            }
            await Task.Delay(3600000, stoppingToken); // Hver time
        }
    }
}
