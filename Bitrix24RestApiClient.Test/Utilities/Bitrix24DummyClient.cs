using Newtonsoft.Json;
using System.Threading.Tasks;
using BXRest.Core.Client;
using BXRest.Core.Models.Enums;

namespace BXRest.Test.Utilities
{
    public class Bitrix24DummyClient : IBitrix24Client
    {
        public string LastRequestArgs { get; set; }

        public Task<TResponse> SendPostRequest<TArgs, TResponse>(EntryPointPrefix entityTypePrefix, EntityMethod method, TArgs args) where TResponse : class
        {
            LastRequestArgs = JsonConvert.SerializeObject(args);
            return Task.FromResult<TResponse>(null);
        }
    }
}
