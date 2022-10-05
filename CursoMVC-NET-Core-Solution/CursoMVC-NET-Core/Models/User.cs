using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_NET_Core.Models
{
    //MODELO: Clase que sirve para la representacion de datos
    
    //Este "User.cs" es diferente al que obtuve del EntityFramework, porque no usaré todos los atributos de tiene en el DB
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
