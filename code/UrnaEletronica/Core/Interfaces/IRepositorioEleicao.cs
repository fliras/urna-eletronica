using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepositorioEleicao
    {
        int Criar(Eleicao eleicao);
        void OfertarCargo(int idEleicao, CargoConcorrido cargo);
    }
}
