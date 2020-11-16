using AmdarisInternship.API.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmdarisInternship.API.Tests
{
    [TestClass]
    public class ModuleControllerIntegrationTests
    {
        private readonly HttpClient _client;

        public ModuleControllerIntegrationTests()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }

        [TestMethod]
        public async Task ShouldAccess_Get()
        {
            var request = "/api/Module";
            var response = await _client.GetAsync(request);
            response.EnsureSuccessStatusCode();
            //var jsonFromPostResponse = await response.Content.ReadAsStringAsync();
            //var obj = JsonConvert.DeserializeObject<List<ModuleWithModuleGradingDto>>(jsonFromPostResponse);
            //Assert.IsTrue(obj.Count == 9);
        }

        [TestMethod]
        public async Task ShouldAccess_GetById()
        {
            var request = "/api/Module/1";
            var response = await _client.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonFromPostResponse = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<List<ModuleWithModuleGradingDto>>(jsonFromPostResponse);
                Assert.AreEqual(obj[0].Module.Name, "C#");
                Assert.IsTrue(obj[0].ModuleGradings.Count == 4);
            }
            response.EnsureSuccessStatusCode();
        }

        [TestMethod]
        public async Task ShouldAccess_Post()
        {
            var request = new
            {
                Url = "/api/Module",
                Body = new
                {

                }
            };

            var postResponse = await _client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            postResponse.EnsureSuccessStatusCode();
        }

        [TestMethod]
        public async Task ShouldAccess_Put()
        {
            var request = new
            {
                Url = "/api/Module/1",
                Body = new
                {

                }
            };

            var putResponse = await _client.PatchAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            putResponse.EnsureSuccessStatusCode();
        }
    }
}
