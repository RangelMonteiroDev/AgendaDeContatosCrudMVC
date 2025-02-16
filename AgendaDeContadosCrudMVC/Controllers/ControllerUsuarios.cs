using AgendaDeContadosCrudMVC.data;
using AgendaDeContadosCrudMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDeContadosCrudMVC.Controllers
{   
    [ApiController]
    [Route("Usuarios")]
    public class ControllerUsuarios : Controller
    {
        private readonly AppDbContext _context;

        public ControllerUsuarios(AppDbContext context) {

            _context = context;
        }
        
        //Mostrar a Tabela de Usuarios
        [HttpGet("UserList")]
        public IActionResult UserList () {

            return View();
        }

        [HttpGet("UserCadastro")]
        public IActionResult UserCadastro () {

            return View();
        }


        //Inserir dados na Tabela de Usuarios
        [HttpPost("Create")]
        public IActionResult Create (Usuarios usuarios) {

            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuarios);
                _context.SaveChanges();

                return Ok(new {Message = "Dados Inseridos com Sucesso"});
            }
            else
            {
                return BadRequest();
            }
        }
        //Leitura de todos os dados da Tabela
        [HttpGet("GetAll")]
        public IActionResult GetAll () {

            var existsResults = _context.Usuarios.ToList();

            if (existsResults.Any())
            {
                return NotFound(new { message = "Dados não Encontrados"});
            }
            else
            {   
                Console.WriteLine("Dados enviados: Metodo GetAll, Classe UsuariosConroller");

                return Ok(existsResults);
            }
        }

        //Retornando o Id do Usuario
        [HttpGet("GetId")]
        public IActionResult GetId (string EmailUsuario, string SenhaUsuario) {

            var existsResults = _context.Usuarios.FirstOrDefault(u => u.EmailUsuario == EmailUsuario && u.Senha == SenhaUsuario);

            if (existsResults != null)
            {
                return Ok(existsResults.IdUsuario);
            }
            else
            {
                return NotFound(new {Message = "Dados não Encontrados"});
            }
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get (int id) {

            var existsResults = _context.Usuarios.Find(id);

            if (existsResults != null)
            {
                return Ok(existsResults);
            }
            else
            {
                return NotFound(new {message = "Dados não encontrados"});
            }

        }

        //Obs: Guardar Id do Usuário no Cache do navegador, se preferir agilizar
        [HttpPut("Update/{id}")]
        public IActionResult Update (int id, [FromBody] Usuarios usuarios) {

            var existsResults = _context.Usuarios.Find(id);

            if (existsResults != null)
            {
                existsResults.NomeUsuario = usuarios.NomeUsuario;
                existsResults.EmailUsuario = usuarios.EmailUsuario;
                existsResults.CellNumber = usuarios.CellNumber;
                existsResults.Ativo = usuarios.Ativo;
                existsResults.Senha = usuarios.Senha;

                _context.Usuarios.Update(existsResults);
                _context.SaveChanges();

                return Ok(new {message = "Dados atualizados com sucesso"});
            }
            else
            {
                return NotFound(new {message = "Dados não encontrados"});
            }
        }

        //Atualizando apenas o estado do usuário
        [HttpPut("UpdateState/{id}")]
        public IActionResult UpdateState (int id, [FromBody] bool state) {

            var existsResults = _context.Usuarios.Find(id);

            if (existsResults != null)
            {
                existsResults.Ativo = state;

                _context.Usuarios.Update(existsResults);
                _context.SaveChanges();

                return Ok(new {message = "Dados atualizados com sucesso"});
            }
            else
            {
                return NotFound(new {message = "Dados não  encontrados"});
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete (int id) {

            var existsResults = _context.Usuarios.Find(id);

            if (existsResults != null)
            {
                _context.Usuarios.Remove(existsResults);
                _context.SaveChanges();

                return Ok(new {message = "Dados deletados com sucesso"});
            }
            else
            {
                return NotFound(new {message = "Dados não encontrados"});
            }
        }
    }
}