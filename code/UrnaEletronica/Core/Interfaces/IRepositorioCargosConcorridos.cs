using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepositorioCargosConcorridos
    {
        CargoConcorrido[] ObterCargosPeloIdDaEleicao(int idEleicao);
        CargoConcorrido[] ObterCargosComVotosValidos(int idEleicao);
    }
}
