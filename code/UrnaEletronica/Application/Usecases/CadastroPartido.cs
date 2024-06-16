using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;
using Core.Exceptions;

namespace Application.Usecases
{
    internal class CadastroPartido : ICadastroPartido
    {
        private readonly IRepositorioPartidos _repoPartidos;

        public CadastroPartido(IRepositorioPartidos repositorioPartidos)
        {
            _repoPartidos = repositorioPartidos;
        }

        public int Handle(CadastroPartidoDto cadastroPartido)
        {
            Partido partidoExistente = _repoPartidos.ObterPeloDigito(cadastroPartido.Digito);
            if (partidoExistente != null)
                throw new DigitoDePartidoEmUsoException();
            Partido novoPartido = new Partido()
            {
                Nome = cadastroPartido.Nome,
                Digito = cadastroPartido.Digito
            };
            return _repoPartidos.Criar(novoPartido);
        }
    }
}
