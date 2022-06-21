using Newtonsoft.Json;

namespace Utility.Model
{
    public  class TeamEvent
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type_of_event")]
        public string TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        public override string ToString()
        {
            return $"{Player}";
        }
    }
}
