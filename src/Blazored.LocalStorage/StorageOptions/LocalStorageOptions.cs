using System.Text.Json;

namespace RA.Blazored.LocalStorage.StorageOptions
{
    public class LocalStorageOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; set; } = new JsonSerializerOptions();
    }
}
