using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
    }

    
}
