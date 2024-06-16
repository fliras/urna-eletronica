using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    public class CadastroEleicao : ICadastroEleicao
    {
        private readonly IRepositorioEleicao _repoEleicao;

        public CadastroEleicao(IRepositorioEleicao repositorioEleicao)
        {
            _repoEleicao = repositorioEleicao;
        }

        public int Handle(CadastroEleicaoDto cadastroEleicao)
        {
            Eleicao novaEleicao = new Eleicao() { Nome = cadastroEleicao.Nome };
            int idNovaEleicao = _repoEleicao.Criar(novaEleicao);
            foreach (CargoConcorrido cargo in cadastroEleicao.CargosConcorridos)
                _repoEleicao.OfertarCargo(idNovaEleicao, cargo);
            return idNovaEleicao;
        }
    }
}
