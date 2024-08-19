using BXRest.Core.Client;

namespace BXRest.Api
{
    /// <summary>
    /// Раздел по работе с задачами
    /// </summary>
    /// <param name="client"></param>
    public class Task(IBitrix24Client client)
    {
        /// Свойство для работы с затраченным временем по задачам
        public TaskMethods.ElapsedItem ElapsedItem { get; set; } = new TaskMethods.ElapsedItem(client);
        /// Свойство для работы с затраченным временем по задачам
        public TaskMethods.Item Item { get; set; } = new TaskMethods.Item(client);
    }
}
