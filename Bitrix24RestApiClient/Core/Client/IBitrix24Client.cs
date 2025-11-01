using System.Threading.Tasks;

namespace BXRest.Core.Client
{
    /// Интерфейс конечного запроса
    public interface IBitrix24Client
    {
        /// Интерфейс конечного запроса
        Task<TResponse> SendPostRequest<TArgs, TResponse>(string method, TArgs args) where TResponse : class;
    }
}
