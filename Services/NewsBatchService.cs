namespace NewsS.Services
{
    public class NewsBatchService :BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                //ここが1日1回の処理
                Console.WriteLine("バッチ実行");

                await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
            }
        }
    }
}
