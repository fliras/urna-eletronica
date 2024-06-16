using Core.Exceptions;

namespace Core.Entities
{
    public class CargoConcorrido
    {
        private ChapaEleitoral[] chapasEleitorais;

        public int IdCargo { get; set; }
        public ChapaEleitoral[] ChapasEleitorais
        {
            get => chapasEleitorais;
            set
            {
                if (value.Length < 2)
                    throw new ChapasInsuficientesException();
                chapasEleitorais = value;
            }
        }
    }
}
