using GGTIDA.Middleware.Login;
using Microsoft.AspNetCore.SignalR;

namespace GETIDA.WebPortal.Server.Hubs
{
    public class LoginHub:Hub
    {

        public async Task SendMessage(string user, string message)
        {
            DbLogin dbLogin = new DbLogin();
            string s = dbLogin.getResponse(user, message, "DbLogin responses");
            await Clients.Caller.SendAsync("ReceiveMessage", user, s);
        }

    }
}
