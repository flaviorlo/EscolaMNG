using Dominio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> GetAlunos();
        Task<Aluno> GetIdAlunos(int Id);
        Task<bool> Create(Aluno dados);
        Task<Aluno> Update();
        Task<bool> Delete(int Id);


    }
}
