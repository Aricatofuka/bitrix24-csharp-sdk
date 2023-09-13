using BXRest.Core.Client;

namespace BXRest.Api.TaskMetodts
{
    public class Item
    {
        private IBitrix24Client client;
        public ItemMetodts.Userfield Userfield;
        /// <summary>
        /// init
        /// </summary>
        /// <param name="client"></param>
        public Item(IBitrix24Client client)
        {
            this.client = client;
            Userfield = new ItemMetodts.Userfield(client);
        }
    }
}
