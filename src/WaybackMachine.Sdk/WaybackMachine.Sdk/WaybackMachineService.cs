using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WaybackMachine.Sdk.Constants;
using WaybackMachine.Sdk.Extensions;
using WaybackMachine.Sdk.Helpers;
using WaybackMachine.Sdk.Models;

namespace WaybackMachine.Sdk
{
    public class WaybackMachineService
    {
        public readonly HttpClient httpClient;

        public WaybackMachineService()
        {
            httpClient.BaseAddress = new Uri(UrlConstants.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
        }

        public async Task<Snapshot> GetMostRecentSnapshotAsync(string url) 
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Snapshot snapshot = JsonConvert.DeserializeObject<Snapshot>(responseString);
            
            return snapshot;
        }

        public async Task<Snapshot> GetSnapshotClosestToDateAsync(string url, DateTime date)
        {
            string requestUrl = RequestUrlHelpers.ConstructRequestWithTimestamp(url, date);

            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Snapshot snapshot = JsonConvert.DeserializeObject<Snapshot>(responseString);
            
            return snapshot;
        }

        public async Task<bool> HasSnapshot(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Snapshot snapshot = JsonConvert.DeserializeObject<Snapshot>(responseString);
            
            return ObjectExtensions.HasProperty(snapshot, nameof(ArchivedSnapshots));
        }
    }
}