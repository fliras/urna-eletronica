using Application.DTOs;

namespace Application.Interfaces
{
    public interface IRegistroVotos
    {
        void Handle(VotoDto[] votos);
    }
}
