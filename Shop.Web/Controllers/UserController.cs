using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Shop.Data;
using Shop.Service;

namespace Shop.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUserList = userService.GetUsers();
            return View(objUserList);
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                userService.InsertUser(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }

    
}
