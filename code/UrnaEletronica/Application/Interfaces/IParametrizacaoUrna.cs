using Core.Entities;

namespace Application.Interfaces
{
    public interface IParametrizacaoUrna
    {
        void Handle(ParametroUrna[] parametros);
    }
}
