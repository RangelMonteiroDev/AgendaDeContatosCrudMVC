using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDeContadosCrudMVC.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario {get; set;}
        public required string NomeUsuario {get; set;}
        public required string EmailUsuario {get; set;}
        public required int CellNumber {get; set;}
        public required bool Ativo {get; set;}
        public required string Senha {get;set;}
    }
}