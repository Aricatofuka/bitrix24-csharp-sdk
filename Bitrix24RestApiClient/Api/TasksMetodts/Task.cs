using BXRest.Core.Client;
using BXRest.Core.Models;
using BXRest.Core.Models.Response;
using BXRest.Models.Tasks.Task;
using System.Threading.Tasks;

namespace BXRest.Api.TasksMetodts
{
    /// <summary>
    /// https://dev.1c-bitrix.ru/rest_help/tasks/task/tasks/index.php
    /// </summary>
    public class Task
    {

        private IBitrix24Client client;

        public Task(IBitrix24Client client)
        {
            this.client = client;
        }

        /// <summary>
        /// Создает задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<iTask>> Add(iAdd param)
        {
            return await client.SendPostRequest<iAdd, iBXRespnse<iTask>>(RestMedots.Tasks.Task.Add, param);
        }

        /*
        tasks.task.approve Позволяет принять задачу
        tasks.task.complete Переводит задачу в статус «завершена»
        tasks.task.counters.get Получает счетчики пользователя
        tasks.task.deger Переводит задачу в статус «отложена»
        tasks.task.delegate Метод для делегирования задачи
        tasks.task.delete Удаляет задачу
        tasks.task.disapprove Позволяет отклонить задачу
        tasks.task.favorite.add Добавляет задачи в "Избранное"
        tasks.task.favorite.remove Удаляет задачи из "Избранного"
        tasks.task.files.attach Прикрепляет загруженный на диск файл к задаче
        */

        /// <summary>
        /// Получить задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<iGetResult>> Get(iGet param)
        {
            return await client.SendPostRequest<iGet, iBXRespnse<iGetResult>>(RestMedots.Tasks.Task.Get, param);
        }
        /*
        tasks.task.getFields Возвращает все доступные поля
        tasks.task.getaccess Метод для проверки доступа к задаче
        tasks.task.history.list Получает историю задачи
        */

        /// <summary>
        /// Получить список задач
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<iListResult>> List(iList param)
        {
            return await client.SendPostRequest<iList, iBXRespnse<iListResult>>(RestMedots.Tasks.Task.List, param);
        }
        /*
        tasks.task.list Возвращает массив задач, каждая из которых содержит массив полей
        tasks.task.pause Останавливает выполнение задачи, переводя ее в статус "ждет выполнения"
        tasks.task.renew Возобновляет задачу после ее завершения
        tasks.task.start Переводит задачу в статус «выполняется»
        tasks.task.startwatch Позволяет наблюдать за задачей
        tasks.task.stopwatch Останавливает наблюдение за задачей
        tasks.task.update Обновляет задачу
        */
    }
}
