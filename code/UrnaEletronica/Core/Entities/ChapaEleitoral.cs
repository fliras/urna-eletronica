using Core.Exceptions;

namespace Core.Entities
{
    public class ChapaEleitoral
    {
        private int[] idsDosCandidatos;

        public int Id { get; set; }
        public string Digito { get; set; }
        public int IdPartido { get; set; }
        public int[] IdsDosCandidatos
        {
            get => idsDosCandidatos;
            set
            {
                if (value.Length == 0)
                    throw new CandidatosInsuficientesException();
                idsDosCandidatos = value;
            }
        }
    }
}
