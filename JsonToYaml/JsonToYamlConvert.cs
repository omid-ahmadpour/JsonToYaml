using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace JsonToYaml
{
    public static class JsonToYamlConvert
    {
        public static string ConvertJsonToYaml(string jsonString)
        {
            var expandoObjectConverter = new ExpandoObjectConverter();
            dynamic deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(jsonString, expandoObjectConverter);

            var serializer = new YamlDotNet.Serialization.Serializer();
            string yaml = serializer.Serialize(deserializedObject);

            return yaml;
        }
    }
}
