using Newtonsoft.Json;
using System;

namespace WaybackMachine.Sdk.Models
{
    /// <summary>
    /// Model for the snapshots returned by
    /// the Wayback Machine API.
    /// </summary>
    public class Snapshot
    {
        [JsonProperty("archived_snapshots")]
        public ArchivedSnapshots ArchivedSnapshots { get; set; }
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
        public string Timestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}