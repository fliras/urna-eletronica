using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    public class RegistroVotos : IRegistroVotos
    {
        private readonly IRepositorioVotos _repoVotos;

        public RegistroVotos(IRepositorioVotos repositorioVotos)
        {
            _repoVotos = repositorioVotos;
        }

        public void Handle(VotoDto[] votos)
        {
            foreach (VotoDto v in votos)
            {
                Voto novoVoto = new Voto()
                {
                    IdChapa = v.IdChapaEleitoral,
                    IdEleicao = v.IdEleicao
                };
                _repoVotos.Criar(novoVoto);
            }
        }
    }
}
