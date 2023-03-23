using Dominio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Service.Interface;

namespace EscolaMNG.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoService _alunoservice;

        public AlunoController(IAlunoService alunoservice)
        {
            _alunoservice = alunoservice;
        }

        [HttpGet]
        public async Task<IEnumerable<Aluno>> GetAlunos() 
        {
            try
            {
                var dados = await _alunoservice.GetAlunos();
                return dados.ToList();
            }
            catch
            {
                return (IEnumerable<Aluno>)BadRequest("Request Invalid");
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
    }
}
