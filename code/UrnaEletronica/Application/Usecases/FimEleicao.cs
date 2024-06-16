using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;
using Core.Exceptions;
using System;

namespace Application.Usecases
{
    public class FimEleicao : IFimEleicao
    {
        private readonly IRepositorioEleicao _repoEleicao;
        private readonly IRepositorioCargosConcorridos _repoCargosConcorridos;

        public FimEleicao(IRepositorioEleicao repositorioEleicao, IRepositorioCargosConcorridos repositorioCargosConcorridos)
        {
            _repoEleicao = repositorioEleicao;
            _repoCargosConcorridos = repositorioCargosConcorridos;
        }

        public void Handle(int idEleicao)
        {
            Eleicao eleicao = _repoEleicao.ObterPeloId(idEleicao);
            if (eleicao.DataFim != null)
                throw new EleicaoJaFinalizadaException();
            CargoConcorrido[] cargosComVotosValidos = _repoCargosConcorridos.ObterCargosComVotosValidos(idEleicao);
            CargoConcorrido[] cargosDaEleicao = _repoCargosConcorridos.ObterCargosPeloIdDaEleicao(idEleicao);
            bool todosOsCargosForamVotados = cargosComVotosValidos.Length == cargosDaEleicao.Length;
            if (!todosOsCargosForamVotados)
                throw new CargoNaoVotadoException();
            eleicao.DataFim = DateTime.UtcNow.ToString();
            _repoEleicao.Atualizar(eleicao);
        }
    }
}
