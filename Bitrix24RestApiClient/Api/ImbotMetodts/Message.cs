using BXRest.Core.Client;
using BXRest.Core.Models;

namespace BXRest.Api.ImbotMetodts
{
    public class Message
    {
        private IBitrix24Client client;

        public Message(IBitrix24Client client)
        {
            this.client = client;
        }

        public dynamic Add(dynamic param, string auth) {
            return client.SendPostRequest(RestMedots.Imbot.Message.Add, param);
        }
    }
}
