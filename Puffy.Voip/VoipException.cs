using System;

namespace Puffy.Voip
{
    public class VoipException : Exception
    {
        public VoipException(string message)
            : base(message)
        {
        }
    }
}
