using System;

namespace Core.Exceptions
{
    public class CandidatosInsuficientesException : Exception
    {
        public CandidatosInsuficientesException()
            : base ("A chapa informada deve possuir ao menos um candidato") {}
    }
}
