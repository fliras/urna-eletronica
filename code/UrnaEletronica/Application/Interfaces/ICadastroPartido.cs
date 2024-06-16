using Application.DTOs;

namespace Application.Interfaces
{
    public interface ICadastroPartido
    {
        int Handle(CadastroPartidoDto cadastroPartido);
    }
}
