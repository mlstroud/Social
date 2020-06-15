using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Social.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Social.Hubs
{
  public class ChatHub : Hub
  {
    private readonly SocialContext _db;

    public ChatHub(SocialContext db)
    {
      _db = db;
    }

    public async Task SendMessage(string user, string message)
    {
      await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public async Task SendPrivateMessage(string toUser, string fromUser, string message)
    {
      await Clients.User(toUser).SendAsync("ReceiveMessage", fromUser, message);

      Message mess = new Message();

      ApplicationUser toUserObject = _db.Users.Where(w => w.Id == toUser).FirstOrDefault();
      ApplicationUser fromUserObject = _db.Users.Where(w => w.UserName == fromUser).FirstOrDefault();
      mess.ToUser = toUserObject;
      mess.FromUser = fromUserObject;
      mess.Content = message;
      _db.Messages.Add(mess);
      _db.SaveChanges();


      // mess.ToUser = toUser;
    }
  }
}