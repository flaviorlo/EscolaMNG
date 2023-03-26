using AppReact._2_Domain.Model;
using AppReact._3_Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AppReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoService _alunoservice;

        public AlunoController(IAlunoService alunoservice)
        {
            _alunoservice = alunoservice;
        }

        [HttpGet]
        [Route("GetAllAlunos")]
        public async Task<IActionResult> GetAllAlunos()
        {
            try
            {
                var dados = await _alunoservice.GetAlunos();
                return StatusCode(StatusCodes.Status200OK, dados.ToList());
            }
            catch
            {
                return BadRequest("Request Invalid");
            }

        }

        [HttpPost("/Cadastrar")]
        public async Task<bool> CreateAluno(Aluno dados)
        {
            try
            {
                return await _alunoservice.Create(dados);
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete("/Deletar")]
        public async Task<bool> DeleteAluno(int Id)
        {
            try
            {
                return await _alunoservice.Delete(Id);
            }
            catch
            {
                return false;
            }
        }
    }


}
