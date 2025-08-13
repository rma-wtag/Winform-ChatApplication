using Microsoft.AspNetCore.SignalR;
namespace SignalR
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string receiver, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, receiver, message);
        }
    }
}
