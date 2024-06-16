using System;

namespace Core.Exceptions
{
    public class DigitoDePartidoEmUsoException : Exception
    {
        public DigitoDePartidoEmUsoException()
            : base ("O Dígito deste partido já está em uso") { }
    }
}
