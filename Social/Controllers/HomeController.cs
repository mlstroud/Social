using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Social.Models;
using System.Web;
using System;

namespace Social.Controllers
{
  public class HomeController : Controller
  {
    private readonly SocialContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(SocialContext db, UserManager<ApplicationUser> userManager)
    {
      _db = db;
      _userManager = userManager;
    }

    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/FindFriends")]
    public ActionResult FindFriends()
    {
      var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
      List<ApplicationUser> allUsers = _db.Users.Where(user => user.Id != userId).ToList();
      return View(allUsers);
    }

    [HttpGet("/Profile/{name}")]
    public ActionResult Profile(string name)
    {
      ViewBag.Friends = _db.Friends.Where(user => user.User.UserName == name).Include(user => user.UserFriend).ToList();
      ApplicationUser thisUser = _db.Users.Where(user => user.UserName == name).FirstOrDefault();
      return View(thisUser);
    }

    [HttpPost]
    public ActionResult FindFriends(string userName)
    {
      // ApplicationUser userToAdd = _db.Users.Where(users => users.UserName == userName).FirstOrDefault();
      // Friend newFriend = new Friend();
      // string myName = User.FindFirstValue(ClaimTypes.Name);
      // newFriend.User = _db.Users.Where(users => users.UserName == myName).FirstOrDefault();
      // newFriend.UserFriend = userToAdd;
      // Console.WriteLine(newFriend.User);
      // Console.WriteLine(newFriend.UserFriend);
      Console.WriteLine(userName);
      return RedirectToAction("Index", "Home");
    }
  }
}
