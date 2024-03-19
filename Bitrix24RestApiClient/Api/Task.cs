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
        public TaskMetodts.ElapsedItem ElapsedItem { get; set; } = new TaskMetodts.ElapsedItem(client);
        /// Свойство для работы с затраченным временем по задачам
        public TaskMetodts.Item Item { get; set; } = new TaskMetodts.Item(client);
    }
}
