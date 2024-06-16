using Core.Entities;

namespace Application.DTOs
{
    public class CadastroEleicaoDto
    {
        public string Nome { get; set; }
        public CargoConcorrido[] CargosConcorridos { get; set; }
    }
}
