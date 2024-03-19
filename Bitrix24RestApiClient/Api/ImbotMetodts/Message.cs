using BXRest.Core.Client;
using BXRest.Core.Models;

namespace BXRest.Api.ImbotMetodts
{
    /// Раздела по работе с ботами
    public class Message(IBitrix24Client client)
    {
        private IBitrix24Client client = client;

        /// Добавление бота
        public dynamic Add(dynamic param, string auth) {
            return client.SendPostRequest(RestMedots.Imbot.Message.Add, param);
        }
    }
}
