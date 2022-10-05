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
            User user = new User();
            user.Nombre = "Juan";
            user.Email = "Correo@gmail.com";
            return View(user);
        }
    }
}
