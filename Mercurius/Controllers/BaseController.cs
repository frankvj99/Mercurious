using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mercurius.Controllers
{
    public class BaseController : Controller
    {
        private DbContext _context;

        public BaseController() 
        {
        }
    }
}