using System;

namespace Core.Exceptions
{
    public class CargoNaoVotadoException : Exception
    {
        public CargoNaoVotadoException()
            : base ("Há um cargo sem votos válidos") { }
    }
}
