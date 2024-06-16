using System;

namespace Core.Exceptions
{
    public class ChapasInsuficientesException : Exception
    {
        public ChapasInsuficientesException()
            : base ("O cargo ofertado teve ter no mínimo duas chapas") {}
    }
}
