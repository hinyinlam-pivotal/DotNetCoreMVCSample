using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreWebAppSample
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult Kill()
        {
            Environment.Exit(-1);
            return null;
        }

        public IActionResult ThrowException()
        {
            throw new SystemException("This is a generated system exception in ErrorController.ThrowException");
        }
    }
}
