using ArquivoBaseBootcamp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using ArquivoBaseBootcamp.Model;

namespace ArquivoBaseBootcamp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InteresseController : ControllerBase
    {
        private readonly IInteresseService _interesseService;

        public InteresseController(IInteresseService interesseService)
        {
            _interesseService = interesseService;
        }

        /// <summary>
        /// Este endpoint deve consultar as interessadas cadastradas
        /// </summary>
        /// <returns>
        /// Retorna a lista com todas as interessadas cadastradas
        /// </returns>
        [HttpGet]
        public IActionResult ConsultarTodosInteresses()
        {
            var todasAsInteressadas = _interesseService.ConsultarTodos();
            return Ok(todasAsInteressadas);
            
        }

        /// <summary>
        /// Este endpoint deve consultar a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpGet]
        [Route("consultar/email")]
        public IActionResult ConsultarInteresse(string email)
        {
            if (_interesseService.ConsultarPorEmail(email) != null) //se for vazio, o email não foi encontrado
            {
                return Ok(_interesseService.ConsultarPorEmail(email)); //retorna dados da interessada consultada
            }
            else
            {
                return NotFound("Não está no cadastro");
            }
        }

        /// <summary>
        ///  Este endpoint deve realizar o inclusao de uma interessada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPost]
        [Route("incluir")]
        public IActionResult AdicionarInteresse(Interessada interessada)
        {

            if(_interesseService.Incluir(interessada) == interessada) //explicações no método Incluir
            {
                return Conflict("Já está cadastrada"));

            }
            else if (_interesseService.Incluir(interessada) == null)
            {
                return BadRequest("E-mail ou nome inválidos. Tente novamente.");
            }
            else
            {
                return Ok("Cadastrada com sucesso!")
            }
        }

        /// <summary>
        /// Este endpoint deve atualizar os dados da interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpPut]
        [Route("atualizar/email")]
        public IActionResult AtualizarInteresse(string novoEmail, Interessada interessada)
        {
            if (_interesseService.AtualizarEmail(novoEmail, interessada) == null)
            {
                return NotFound("Usuário não encontrado");
            }
            else
            {
                return Ok(_interesseService.AtualizarEmail(novoEmail, interessada));
            }
        }

        /// <summary>
        /// Este endpoint deve excluir a interessada cadastrada
        /// </summary>
        /// <returns>
        /// Retorna 2xx caso sucesso
        /// Retorna 4xx caso erro
        /// </returns>
        [HttpDelete]
        [Route("excluir/email")]
        public IActionResult ExcluirInteresse()
        {
            if (_interesseService.ExcluirPorEmail() == true)
            {
                return Ok("Excluida com sucesso!");
            }
            else
            {
                return NotFound("Não encontrado");
            }
        }
    }
}
