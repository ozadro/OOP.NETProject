﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Model
{
   public class States
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long? GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        public override string ToString()
        => $"{FifaCode}";
    }
}
