using Core.Entities;

namespace Core.Interfaces
{
    public interface IRepositorioPartidos
    {
        int Criar(Partido partido);
        Partido ObterPeloDigito(string digito);
    }
}
