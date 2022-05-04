using System;
using System.Net;

namespace Sender.UniOne.ApiClient.Infrastructure.Exceptions
{
    [Serializable]
    public class UniOneClientException : Exception
    {
        internal UniOneClientException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        internal UniOneClientException(HttpStatusCode statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}