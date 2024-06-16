using System;

namespace Core.Exceptions
{
    public class EleicaoEmAndamentoException : Exception
    {
        public EleicaoEmAndamentoException()
            : base ("Já há uma eleição em andamento") { }
    }
}
