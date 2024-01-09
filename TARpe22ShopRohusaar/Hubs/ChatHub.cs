using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace TARpe22ShopRohusaar.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
