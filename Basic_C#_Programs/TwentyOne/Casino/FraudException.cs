using System;

namespace Casino
{
    internal class FraudException : Exception // inherits from Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
