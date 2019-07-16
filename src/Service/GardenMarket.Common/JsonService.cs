using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GardenMarket.Common
{
    public class JsonService : IJsonService
    {
        public T Deserialize<T>(string value) =>
            JsonConvert.DeserializeObject<T>(value);

        public Task<T> DeserializeAsync<T>(string value) =>
            Task.FromResult(JsonConvert.DeserializeObject<T>(value));

        public string Serialize<T>(T obj) =>
            JsonConvert.SerializeObject(obj);

        public Task<string> SerializeAsync<T>(T obj) =>
            Task.FromResult(JsonConvert.SerializeObject(obj));
    }
}