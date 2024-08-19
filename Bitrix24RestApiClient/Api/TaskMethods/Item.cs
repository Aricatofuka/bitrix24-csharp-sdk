using BXRest.Core.Client;

namespace BXRest.Api.TaskMethods
{

    /// <summary>
    /// init
    /// </summary>
    /// <param name="client"></param>
    public class Item(IBitrix24Client client)
    {
        private IBitrix24Client client = client;

        /// https://dev.1c-bitrix.ru/rest_help/tasks/task/userfield/index.php
        public TaskMethods.ItemMethods.UserField UserField = new(client);
    }
}
