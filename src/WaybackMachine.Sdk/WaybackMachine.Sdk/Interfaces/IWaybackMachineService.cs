using System;
using System.Threading.Tasks;
using WaybackMachine.Sdk.Models;

namespace WaybackMachine.Sdk.Interfaces
{
    public interface IWaybackMachineService
    {
        public Task<Snapshot> GetMostRecentSnapshotAsync(string url);
        public Task<Snapshot> GetSnapshotClosestToDateAsync(DateTime date);
    }
}