using Application.DTOs;

namespace Application.Interfaces
{
    internal interface ICadastroEleicao
    {
        int Handle(CadastroEleicaoDto cadastroEleicao);
    }
}
