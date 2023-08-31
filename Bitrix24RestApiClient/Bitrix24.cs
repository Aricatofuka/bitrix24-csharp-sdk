using BXRest.Api;
using BXRest.Core.Client;

namespace BXRest
{
    /// <summary>
    /// Контейнер для АПИ битрикс24. Все общение с битрикс24 ведется через него.
    /// </summary>
    public class Bitrix24
    {
        public Bitrix24(IBitrix24Client client)
        {
            User = new User(client);
            Tasks = new Tasks(client);
            Task = new Task(client);
        }

        public User User { get; private set; }
        public Tasks Tasks { get; private set; }
        public Task Task { get; private set; }
    }
}
