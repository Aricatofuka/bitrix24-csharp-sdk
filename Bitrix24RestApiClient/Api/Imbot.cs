using BXRest.Core.Client;

namespace BXRest.Api
{
    /// Rest api Методы бота
    public class Imbot(IBitrix24Client client)
    {
        /// Раздел сообщений
        public Api.ImbotMetodts.Message Message { get; set; } = new ImbotMetodts.Message(client);
    }
}
