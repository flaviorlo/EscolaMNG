using AppReact._2_Domain.Model;

namespace AppReact._3_Service.Interface
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
