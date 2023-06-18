using ChatApp.Api.Hubs.Clients;
using Microsoft.AspNetCore.SignalR;

namespace ChatApp.Api.Hubs
{
    public class ChatHub : Hub<IChatClient>
    { }
}