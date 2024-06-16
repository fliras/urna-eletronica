using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;
using Core.Exceptions;
using System;

namespace Application.Usecases
{
    public class InicioEleicao : IInicioEleicao
    {
        private readonly IRepositorioEleicao _repoEleicao;

        public InicioEleicao(IRepositorioEleicao repositorioEleicao)
        {
            _repoEleicao = repositorioEleicao;
        }

        public void Handle(int idEleicao)
        {
            Eleicao eleicaoEmAndamento = _repoEleicao.ObterEleicaoEmAndamento();
            if (eleicaoEmAndamento != null)
                throw new EleicaoEmAndamentoException();
            Eleicao eleicao = _repoEleicao.ObterPeloId(idEleicao);
            if (eleicao.DataInicio != null)
                throw new EleicaoJaIniciadaException();
            eleicao.DataInicio = DateTime.UtcNow.ToString();
            _repoEleicao.Atualizar(eleicao);
        }
    }
}
