using Microsoft.AspNetCore.SignalR;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ChatHub : Hub
    {
        ITIContext db;
        public ChatHub(ITIContext db)
        {
            this.db = db;
        }

        public void Sendmessage(string message, string name)
        {

            Chat mess = new Chat()
            {
                Name = name,
                message = message
            };
            db.Chats.Add(mess);
            db.SaveChanges();
            Clients.All.SendAsync("newmessage", name, message);
        }
    }
}
