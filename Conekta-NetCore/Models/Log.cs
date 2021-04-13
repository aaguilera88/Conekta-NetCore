using Conekta_NetStandard.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Conekta_NetStandard
{
    public class Log : Resource
    {
        public JObject[] where(string data = @"{}")
        {
            string result = this.where("/logs", data);

            JObject[] logs = JsonConvert.DeserializeObject<JObject[]>(result, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return logs;
        }
    }
}