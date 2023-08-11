using Grpc.Net.Client;
using GrpcService;

namespace GrpcClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:7143");
            var client = new Notify.NotifyClient(channel);

            var request = new NotificationMessage() { SenderName="Zafar",Text="Hello"};
            var reply = await client.SendNotificationAsync(request);
            Console.WriteLine(reply.IsSuccess);
            Console.ReadKey();
        }
    }
}