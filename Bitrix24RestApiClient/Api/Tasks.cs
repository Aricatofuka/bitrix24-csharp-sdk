using BXRest.Core.Client;

namespace BXRest.Api
{
    public class Tasks
    {
        private IBitrix24Client client;
        public TasksMetodts.Task Task { get; set; }
        public Tasks(IBitrix24Client client)
        {
            this.client = client;
            Task = new TasksMetodts.Task(client);
        }
    }
}
