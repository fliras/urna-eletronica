using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;
using Core.Exceptions;

namespace Application.Usecases
{
    internal class CadastroPartido : ICadastroPartido
    {
        private readonly IRepositorioPartidos repoPartidos;

        public CadastroPartido(IRepositorioPartidos repositorioPartidos)
        {
            repoPartidos = repositorioPartidos;
        }

        public int Handle(CadastroPartidoDto cadastroPartido)
        {
            Partido partidoExistente = repoPartidos.ObterPeloDigito(cadastroPartido.Digito);
            if (partidoExistente != null)
                throw new DigitoDePartidoEmUsoException();
            Partido novoPartido = new Partido()
            {
                Nome = cadastroPartido.Nome,
                Digito = cadastroPartido.Digito
            };
            return repoPartidos.Criar(novoPartido);
        }
    }
}
