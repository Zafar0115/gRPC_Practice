using Grpc.Core;
using GrpcClient;
using Telegram.Bot;

namespace GrpcService.Services
{
    public class NotifyService : Notify.NotifyBase
    {
        private readonly ILogger<NotifyService> logger;
        private readonly ITelegramBotClient client;

        public NotifyService(ILogger<NotifyService> logger, ITelegramBotClient client)
        {
            this.logger = logger;
            this.client = client;
        }

        public override Task<NotificationResponse> SendNotification(NotificationMessage request, ServerCallContext context)
        {
            string message1 = $"Zafar sent this message ";
            client.SendTextMessageAsync("775570501", message1);
            return Task.FromResult(new NotificationResponse
            {
                IsSuccess = true
            });
        }
    }
}
