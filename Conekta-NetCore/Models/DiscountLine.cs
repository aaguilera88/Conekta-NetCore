using Conekta_NetStandard.Base;
using Newtonsoft.Json;

namespace Conekta_NetStandard
{
    public class DiscountLine : Resource
    {
        public string id { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public string parent_id { get; set; }

        public DiscountLine update(string data)
        {
            DiscountLine discount_line = this.toClass(this.toObject(this.update("/orders/" + this.parent_id + "/discount_lines/" + this.id, data)).ToString());
            return discount_line;
        }

        public DiscountLine toClass(string json)
        {
            DiscountLine discount_line = JsonConvert.DeserializeObject<DiscountLine>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return discount_line;
        }
    }
}