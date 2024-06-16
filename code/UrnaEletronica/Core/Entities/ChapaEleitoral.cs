using Core.Exceptions;

namespace Core.Entities
{
    public class ChapaEleitoral
    {
        private int[] _idsDosCandidatos;

        public int Id { get; set; }
        public string Digito { get; set; }
        public int IdPartido { get; set; }
        public int[] IdsDosCandidatos
        {
            get => _idsDosCandidatos;
            set
            {
                if (value.Length == 0)
                    throw new CandidatosInsuficientesException();
                _idsDosCandidatos = value;
            }
        }
    }
}
