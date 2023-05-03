using System.Text.Json;

namespace GenericsExtension
{
    public static class JsonExtension
    {
        public static string ToJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
