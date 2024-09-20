using Newtonsoft.Json;

namespace TheBakery.Services
{
    public class ITempDataSerializer
    {
        public class JsonTempDataSerializer : ITempDataSerializer
        {
            public byte[] Serialize(IDictionary<string, object> values)
            {
                return System.Text.Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(values));
            }

            public IDictionary<string, object> Deserialize(byte[] content)
            {
                var json = System.Text.Encoding.UTF8.GetString(content);
                return JsonConvert.DeserializeObject<IDictionary<string, object>>(json);
            }
        }
    }
}
