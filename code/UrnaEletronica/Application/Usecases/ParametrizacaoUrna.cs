using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    internal class ParametrizacaoUrna : IParametrizacaoUrna
    {
        private readonly IRepositorioUrna _repoUrna;

        public ParametrizacaoUrna(IRepositorioUrna repositorioUrna)
        {
            _repoUrna = repositorioUrna;
        }

        public void Handle(ParametroUrna[] parametros)
        {
            _repoUrna.AtualizarParametros(parametros);
        }
    }
}
