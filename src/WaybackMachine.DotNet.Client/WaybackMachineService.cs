using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WaybackMachine.DotNet.Client.Constants;
using WaybackMachine.DotNet.Client.Extensions;
using WaybackMachine.DotNet.Client.Helpers;
using WaybackMachine.DotNet.Client.Models;

namespace WaybackMachine.DotNet.Client
{
    public class WaybackMachineService
    {
        public readonly HttpClient httpClient = new HttpClient();

        public WaybackMachineService()
        {
            httpClient.BaseAddress = new Uri(UrlConstants.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public async Task<Snapshot> GetMostRecentSnapshotAsync(string url) 
        {
            string requestUrl = RequestUrlHelpers.ConstructRequest(url);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

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
            string requestUrl = RequestUrlHelpers.ConstructRequest(url);
            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            string responseString = await response.Content.ReadAsStringAsync();
            Snapshot snapshot = JsonConvert.DeserializeObject<Snapshot>(responseString);
            
            return snapshot.ArchivedSnapshots.Closest != null;
        }
    }
}