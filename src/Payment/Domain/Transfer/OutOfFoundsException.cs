using System;

namespace Payment.Domain.Transfer
{
    public class OutOfFoundsException : Exception
    {
        internal OutOfFoundsException(Account account, Money money)
        {
            
        }
    }
}