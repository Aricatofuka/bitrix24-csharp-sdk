﻿using System.Threading.Tasks;
using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using System.Collections.Generic;
using BXRest.Models.User;
using BXRest.Core.Models;

namespace BXRest.Api
{

    /// набор методов пространства имен user
    public class User
    {
        private IBitrix24Client client;

        /// init
        public User(IBitrix24Client client)
        {
            this.client = client;
        }
        /*
        public async Task<ListResponse<TEntity>> Search<TEntity>()
        {
            var builder = new SearchRequestBuilder<TEntity>();
            return await client.SendPostRequest<CrmSearchRequestArgs, ListResponse<TEntity>>(entityTypePrefix, EntityMethod.Search, builder.BuildArgs());
        }

        public async Task<ListResponse<TEntity>> Search<TEntity>(Action<ISearchRequestBuilder<TEntity>> builderFunc)
        {
            var builder = new SearchRequestBuilder<TEntity>();
            builderFunc(builder);
            return await client.SendPostRequest<CrmSearchRequestArgs, ListResponse<TEntity>>(entityTypePrefix, EntityMethod.Search, builder.BuildArgs());
        }

        public async Task<TEntity> First<TEntity>(Action<ISearchRequestBuilder<TEntity>> builderFunc)
        {
            var builder = new SearchRequestBuilder<TEntity>();
            builderFunc(builder);
            return (await client.SendPostRequest<CrmSearchRequestArgs, ListResponse<TEntity>>(entityTypePrefix, EntityMethod.Search, builder.BuildArgs())).Result.FirstOrDefault();
        }
        */

        /// <summary>
        /// Получение пользователей
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<bool>> Admin(iAdminParam param)
        {
            return await client.SendPostRequest<iAdminParam, iBXRespnse<bool>>(RestMedots.User.Admin, param);
        }

        /// <summary>
        /// Получение пользователей
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<iUser>> Current(iCurrentParam param)
        {
            return await client.SendPostRequest<iCurrentParam, iBXRespnse<iUser>>(RestMedots.User.Current, param);
        }

        /// <summary>
        /// Получение пользователей
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<List<iUser>>> Get(iGet param)
        {
            return await client.SendPostRequest<iGet, iBXRespnse<List<iUser>>>(RestMedots.User.Get, param);
        }

        /*
        public async Task<DeleteResponse> Delete(int id)
        {
            return await client.SendPostRequest<CrmEntityDeleteRequestArgs, DeleteResponse>(entityTypePrefix, EntityMethod.Delete, new CrmEntityDeleteRequestArgs
            {
                Id = id
            });
        }

        public async Task<UpdateResponse> Update<TEntity>(int id, Action<IUpdateRequestBuilder<TEntity>> builderFunc)
        {
            var builder = new UpdateRequestBuilder<TEntity>();
            builder.SetId(id);
            builderFunc(builder);
            return await client.SendPostRequest<object, UpdateResponse>(entityTypePrefix, EntityMethod.Update, builder.BuildArgs(entityTypePrefix));
        }

        public async Task<AddResponse> Add<TEntity>(Action<IAddRequestBuilder<TEntity>> builderFunc)
        {
            var builder = new AddRequestBuilder<TEntity>();
            builderFunc(builder);
            return await client.SendPostRequest<object, AddResponse>(entityTypePrefix, EntityMethod.Add, builder.BuildArgs().Fields);
        }
    */
    }
}
