using System.Threading.Tasks;
using BXRest.Core.Models.Enums;

namespace BXRest.Core.Client
{
    public interface IBitrix24Client
    {
        Task<TResponse> SendPostRequest<TArgs, TResponse>(string metod, TArgs args) where TResponse : class;
    }
}
