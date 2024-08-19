using BXRest.Core.Client;

namespace BXRest.Api
{
    /// https://dev.1c-bitrix.ru/rest_help/tasks/task/tasks/index.php
    public class Tasks(IBitrix24Client client)
    {
        /// tasks.task
        public TasksMethods.Task Task { get; set; } = new TasksMethods.Task(client);
    }
}
