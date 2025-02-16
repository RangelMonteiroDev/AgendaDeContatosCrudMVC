using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDeContadosCrudMVC.Models
{
    public class Login
    {
        [Key]
        public int IdUsuario {get; set;}

        public required string Email {get;set;}

        public required string Senha {get;set;}
    }
}