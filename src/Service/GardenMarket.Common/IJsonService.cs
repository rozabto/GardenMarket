using System.Threading.Tasks;

namespace GardenMarket.Common
{
    public interface IJsonService
    {
        string Serialize<T>(T obj);
        T Deserialize<T>(string value);
        Task<string> SerializeAsync<T>(T obj);
        Task<T> DeserializeAsync<T>(string value);
    }
}
