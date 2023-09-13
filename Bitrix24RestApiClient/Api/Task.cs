using BXRest.Core.Client;

namespace BXRest.Api
{
    public class Task
    {
        private IBitrix24Client client;
        public TaskMetodts.ElapsedItem ElapsedItem { get; set; }
        public TaskMetodts.Item Item { get; set; }

        /// <summary>
        /// init
        /// </summary>
        /// <param name="client"></param>
        public Task(IBitrix24Client client)
        {
            this.client = client;
            ElapsedItem = new TaskMetodts.ElapsedItem(client);
            Item = new TaskMetodts.Item(client);
        }
    }
}
