using System;

namespace Sender.UniOne.ApiClient.Infrastructure.Exceptions
{
    [Serializable]
    public class UniOneClientValidationException : Exception
    {
        internal UniOneClientValidationException(string message)
            : base(message)
        {
      
        }
    }
}
