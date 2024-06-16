using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    internal class CadastroCandidato : ICadastroCandidato
    {
        private readonly IRepositorioCandidatos _repoCandidatos;

        public CadastroCandidato(IRepositorioCandidatos repositorioCandidatos)
        {
            _repoCandidatos = repositorioCandidatos;
        }

        public int Handle(CadastroCandidatoDto cadastroCandidato)
        {
            Candidato novoCandidato = new Candidato()
            {
                Nome = cadastroCandidato.Nome, 
                UriFoto = cadastroCandidato.UriFoto 
            };
            return _repoCandidatos.Criar(novoCandidato);
        }
    }
}
