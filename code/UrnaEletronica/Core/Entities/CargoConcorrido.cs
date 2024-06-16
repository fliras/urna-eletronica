using Core.Exceptions;

namespace Core.Entities
{
    public class CargoConcorrido
    {
        private ChapaEleitoral[] _chapasEleitorais;

        public int IdCargo { get; set; }
        public ChapaEleitoral[] ChapasEleitorais
        {
            get => _chapasEleitorais;
            set
            {
                if (value.Length < 2)
                    throw new ChapasInsuficientesException();
                _chapasEleitorais = value;
            }
        }
    }
}
