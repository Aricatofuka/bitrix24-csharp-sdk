using BXRest.Core.Client;

namespace BXRest.Api
{
    public class Imbot
    {
        private IBitrix24Client client;
        public Api.ImbotMetodts.Message Message { get; set; }
        public Imbot(IBitrix24Client client)
        {
            this.client = client;
            Message = new ImbotMetodts.Message(client);
        }
    }
}
