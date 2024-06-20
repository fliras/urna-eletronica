using Core.Entities;

namespace Application.Interfaces
{
    public interface IParametrizacaoaUrna
    {
        void Handle(ParametroUrna[] parametros);
    }
}
