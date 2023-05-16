using Newtonsoft.Json;
using System.Collections.Generic;

namespace VCAuthn.Models
{
    public class RequestedAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("non_revoked", NullValueHandling = NullValueHandling.Ignore)]
        public RevocationInterval NonRevoked { get; set; }

        [JsonProperty("label"), Optional]
        public string Label { get; set; }

        [JsonProperty("restrictions")]
        public List<AttributeFilter> Restrictions { get; set; }
    }
}
