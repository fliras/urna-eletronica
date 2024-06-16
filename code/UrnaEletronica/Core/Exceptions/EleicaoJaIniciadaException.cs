using System;

namespace Core.Exceptions
{
    public class EleicaoJaIniciadaException : Exception
    {
        public EleicaoJaIniciadaException()
            : base("Esta eleição já foi iniciada") { }
    }
}
