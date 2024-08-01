using BlazerSingalRChatApp.DataAccess;
using Microsoft.AspNetCore.SignalR;

namespace BlazerSignalRChatApp.ChatHubs
{
    public class ChatHub : Hub 
    {
        public async Task SendMessage(Chat chat)
            => await Clients.All.SendAsync("MessageReceived", chat);
    }
}
