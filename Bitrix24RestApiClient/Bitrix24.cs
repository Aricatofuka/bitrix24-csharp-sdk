﻿using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using static BXRest.Api.Models.Base;
using BXRest.Models.Tasks.Task;

namespace BXRest
{
    /// <summary>
    /// Контейнер для АПИ битрикс24. Все общение с битрикс24 ведется через него.
    /// </summary>
    public class Bitrix24
    {
        public Bitrix24(IBitrix24Client client)
        {
            User = new Api.User(client);
            Tasks = new Api.Tasks(client);
            Task = new Api.Task(client);
            SonetGroup = new Api.SonetGroup(client);
        }

        public Api.User User { get; private set; }
        public Api.Tasks Tasks { get; private set; }
        public Api.Task Task { get; private set; }
        public Api.SonetGroup SonetGroup { get; private set; }
    }

    /// <summary>
    /// Вспомогательный класс для битриксововго апи
    /// </summary>
    public class Navvy
    {
        /*
        public T getResult(Func<T> data)
        {
            return data.Result;
        }
        */

        /// <summary>
        /// Зацикленный мeтод для получения всех данных из битрикса по отдельному запросу
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        /// <param name="fan"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<List<R>> getAll<T, R>(Func<T, Task<iGetRespnse<List<R>>>> fan, T param) where T : iBXRestBaseParam
        {
            var respon = await fan(param);

            if (respon.next != null && respon.next != 0)
            {
                param.start = respon.next;

                var respon2 = await getAll(fan, param);

                respon.result.AddRange(respon2);

                return respon.result;
            }
            else
            {
                return respon.result;
            }
        }

        /// <summary>
        /// Отдельный getAll для iListResult
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fan"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<List<iTask>> getAll<T>(Func<T, Task<iGetRespnse<iListResult>>> fan, T param) where T : iBXRestBaseParam
        {
            var respon = await fan(param);

            if (respon.next != null && respon.next != 0)
            {
                param.start = respon.next;

                var respon2 = await getAll(fan, param);

                respon.result.tasks.AddRange(respon2);

                return respon.result.tasks;
            }
            else
            {
                return respon.result.tasks;
            }
        }
    }
}
