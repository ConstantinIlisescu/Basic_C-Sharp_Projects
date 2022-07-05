using System;

namespace Casino
{
    public class FraudException : Exception // inherits from Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
