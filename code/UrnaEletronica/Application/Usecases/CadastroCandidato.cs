using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    internal class CadastroCandidato : ICadastroCandidato
    {
        private readonly IRepositorioCandidatos repoCandidatos;

        public CadastroCandidato(IRepositorioCandidatos repositorioCandidatos)
        {
            repoCandidatos = repositorioCandidatos;
        }

        public int Handle(CadastroCandidatoDto cadastroCandidato)
        {
            Candidato novoCandidato = new Candidato() {
                Nome = cadastroCandidato.Nome, 
                UriFoto = cadastroCandidato.UriFoto 
            };
            return repoCandidatos.Criar(novoCandidato);
        }
    }
}
