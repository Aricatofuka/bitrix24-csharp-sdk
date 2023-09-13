using System.Threading.Tasks;

namespace BXRest.Core.Client
{
    public interface IBitrix24Client
    {
        Task<TResponse> SendPostRequest<TArgs, TResponse>(string metod, TArgs args) where TResponse : class;
    }
}
