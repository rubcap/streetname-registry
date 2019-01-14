namespace StreetNameRegistry.Tests.Testing
{
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    public static class ObjectLogExtensions
    {
        public static string ToLoggableString<T>(this T @object, Formatting formatting = Formatting.None) =>
            $"{typeof(T).Name}: {JsonConvert.SerializeObject(@object, formatting, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects })}";

        public static string ToLoggableString<T>(this IEnumerable<T> objects, Formatting formatting = Formatting.None) =>
            objects.Count() < 5
                ? $"{typeof(T).Name}: {JsonConvert.SerializeObject(objects, formatting, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Objects })}"
                : "...";
    }
}
