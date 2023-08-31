using BXRest.Core.Client;

namespace BXRest.Api
{
    public class Task
    {
        private IBitrix24Client client;
        public TaskMetodts.ElapsedItem ElapsedItem { get; set; }
        public Task(IBitrix24Client client)
        {
            this.client = client;
            ElapsedItem = new TaskMetodts.ElapsedItem(client);
        }
    }
}
