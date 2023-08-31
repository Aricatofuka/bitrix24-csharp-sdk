﻿using Xunit;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;
using BXRest.Api;
using BXRest.Core.Models;
using BXRest.Test.Utilities;
using BXRest.Core.Models.Enums;
using BXRest.Api.Crm.CrmContact.Models;

namespace BXRest.Test.Tests.RequestBodyTests
{
    public class ContactTests : IDisposable
    {
        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "ListTest")]
        public async Task ListTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            int id = 100;
            var bitrix24 = new Bitrix24(client);
            var items = await bitrix24.Crm.Contacts
                            .List<Contact>(x=> x
                                .AddSelect(x=>x.Id, x=>x.Name)
                                .AddFilter(x=>x.Id, id, FilterOperator.GreateThan)
                                .AddOrderBy(x => x.Id));

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs));
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "GetTest")]
        public async Task GetTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            int id = 100;
            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Get<Contact>(id, x => x.Id, x => x.Name);

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs));
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "DeleteTest")]
        public async Task DeleteTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            int id = 100;
            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Delete(id);

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs));
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "UpdateTest")]
        public async Task UpdateTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            int id = 100;
            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Update<Contact>(id, x=> x.SetField(y=>y.Name, "12"));

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs), $"Expected: {JsonConvert.SerializeObject(expectedObj)}, Actual: {client.LastRequestArgs}");
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "AddTest")]
        public async Task AddTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Add<Contact>(x => x.SetField(y => y.Name, "12"));

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs), $"Expected: {JsonConvert.SerializeObject(expectedObj)}, Actual: {client.LastRequestArgs}");
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "UpdateWithPhonesAndEmailsTest")]
        public async Task UpdateWithPhonesAndEmailsTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            int id = 100;
            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Update<Contact>(id, x => 
                                x.SetField(y => y.Name, "12")
                                .AddEmails(x=>x.SetField("test@test.ru", EmailType.Рабочий))
                                .AddPhones(x => x.SetField("+79222222222", PhoneType.Рабочий))
                                );

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs), $"Expected: {JsonConvert.SerializeObject(expectedObj)}, Actual: {client.LastRequestArgs}");
        }

        [Theory]
        [JsonFileData("Tests\\RequestBodyTests\\ContactTests\\сontact.json", "AddWithPhonesAndEmailsTest")]
        public async Task AddWithPhonesAndEmailsTest(object expectedObj)
        {
            Bitrix24DummyClient client = new Bitrix24DummyClient();

            var bitrix24 = new Bitrix24(client);
            var item = await bitrix24.Crm.Contacts
                            .Add<Contact>(x =>
                                x.SetField(y => y.Name, "12")
                                .AddEmails(x => x.SetField("test@test.ru", EmailType.Рабочий))
                                .AddPhones(x => x.SetField("+79222222222", PhoneType.Рабочий))
                                );

            Assert.True(TestHelpers.CompareJsons(expectedObj, client.LastRequestArgs), $"Expected: {JsonConvert.SerializeObject(expectedObj)}, Actual: {client.LastRequestArgs}");
        }

        public void Dispose()
        {
        }
    }
}
