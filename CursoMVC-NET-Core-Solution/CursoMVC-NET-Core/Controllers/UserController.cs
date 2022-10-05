using CursoMVC_NET_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_NET_Core.Controllers
{
    public class UserController : Controller
    {
        //CONTROLADOR: Intermediario entre los modelos y las vistas
        public IActionResult Index()
        {
            List<User> lst = new List<User>();
            using(var db = new Models.DB.CursoMVCNETCoreContext())
            {
                lst = (from d in db.User
                       select new User
                       {
                           Id = d.Id,
                           Email = d.Email
                       }).ToList();
            }
            return View(lst);
        }
    }
}
