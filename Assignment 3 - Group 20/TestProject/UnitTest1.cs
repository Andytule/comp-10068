using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly HttpClient client = new HttpClient();
 
        [TestMethod]
        public async Task TestMethod1Async()
        {
            var resultTask = client.GetAsync($"http://localhost:5001/immunizations");
            var response = await resultTask;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

        [TestMethod]
        public async Task TestMethod2Async()
        {
            var resultTask = client.GetAsync($"http://localhost:5001/immunizations/aerukghadgfjh");
            var response = await resultTask;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

        [TestMethod]
        public async Task TestMethod3Async()
        {
            var resultTask = client.GetAsync($"http://localhost:5001/immunizations/5");
            var response = await resultTask;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }

        [TestMethod]
        public async Task TestMethod4Async()
        {
            var resultTask = client.GetAsync($"http://localhost:5001/providers?firstName=bob");
            var response = await resultTask;
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
