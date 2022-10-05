using System;
using System.Collections.Generic;

namespace CursoMVC_NET_Core.Models.DB
{
    //Este es el "User.cs" que obtuve del Entity Framework
    public partial class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }
    }
}
