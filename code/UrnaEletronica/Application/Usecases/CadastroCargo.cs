using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;

namespace Application.Usecases
{
    internal class CadastroCargo : ICadastroCargo
    {
        private readonly IRepositorioCargos repoCargos;

        public CadastroCargo(IRepositorioCargos repositorioCargos)
        {
            repoCargos = repositorioCargos;
        }

        public int Handle(CadastroCargoDto cadastroCargo)
        {
            Cargo novoCargo = new Cargo() { Nome = cadastroCargo.Nome };
            return repoCargos.Criar(novoCargo);
        }
    }
}
