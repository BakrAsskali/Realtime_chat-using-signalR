using ChatApp.Api.Models;

namespace ChatApp.Api.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}