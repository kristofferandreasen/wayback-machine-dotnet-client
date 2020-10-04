using Newtonsoft.Json;
using System;
using WaybackMachine.DotNet.Client.Helpers;

namespace WaybackMachine.DotNet.Client.Models
{
    /// <summary>
    /// Model for the snapshot returned by
    /// the Wayback Machine API.
    /// </summary>
    public class Snapshot
    {
        [JsonProperty("archived_snapshots")]
        public ArchivedSnapshots ArchivedSnapshots { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ArchivedSnapshots
    {
        [JsonProperty("closest")]
        public Closest Closest { get; set; }
    }

    public class Closest
    {
        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}