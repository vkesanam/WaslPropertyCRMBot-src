using Newtonsoft.Json;

namespace Microsoft.Bot.Sample.LuisBot
{
    public class LiveAssistChannelData
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("skill", NullValueHandling = NullValueHandling.Ignore)]
        public string Skill { get; set; }
    }
}