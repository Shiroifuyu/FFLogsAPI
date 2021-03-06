﻿using System.Text.Json.Serialization;

namespace FFLogs.Net.Models.Reports
{
    public class Reports
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        [JsonPropertyName("start")]
        public long Start { get; set; }
        [JsonPropertyName("end")]
        public long End { get; set; }
        [JsonPropertyName("zone")]
        public long Zone { get; set; }
    }
}