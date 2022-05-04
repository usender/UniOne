using Sender.UniOne.ApiClient;

namespace Sender.UniOne.Test.Methods
{
    public class BaseMethod
    {
        public static Data<TRequest, TResponse> Send<TRequest, TResponse>(TRequest request, TResponse response) where TRequest : class where TResponse : BaseResponse
        {
            return new Data<TRequest, TResponse>(request, response);
        }
    }

    public class Data<TRequest, TResponse> 
    {
        public Data(TRequest request, TResponse response)
        {
            Request = request;
            Response = response;
        }
        public TRequest Request { get; }

        public TResponse Response { get; }
    }
}
