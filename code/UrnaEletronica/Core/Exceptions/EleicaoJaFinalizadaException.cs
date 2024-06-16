using System;

namespace Core.Exceptions
{
    public class EleicaoJaFinalizadaException : Exception
    {
        public EleicaoJaFinalizadaException()
            : base("Esta eleição já foi finalizada") { }
    }
}
