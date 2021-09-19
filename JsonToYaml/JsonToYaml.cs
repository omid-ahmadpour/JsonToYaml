using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace JsonToYaml
{
    public class JsonToYaml : IJsonToYaml
    {
        public string ConvertJsonToYaml(string jsonString)
        {
            var expandoObjectConverter = new ExpandoObjectConverter();
            dynamic deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(jsonString, expandoObjectConverter);

            var serializer = new YamlDotNet.Serialization.Serializer();
            string yaml = serializer.Serialize(deserializedObject);

            return yaml;
        }
    }
}