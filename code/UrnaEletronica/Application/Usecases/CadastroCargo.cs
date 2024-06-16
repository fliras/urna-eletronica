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

        public int Handle(string nomeDoCargo)
        {
            Cargo novoCargo = new Cargo() { Nome = nomeDoCargo };
            return repoCargos.Criar(novoCargo);
        }
    }
}
