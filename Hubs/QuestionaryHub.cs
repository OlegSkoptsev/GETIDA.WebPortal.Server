using Microsoft.AspNetCore.SignalR;

namespace GETIDA.WebPortal.Server.Hubs
{
    public class QuestionaryHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", user, message);
        }
    }
}
