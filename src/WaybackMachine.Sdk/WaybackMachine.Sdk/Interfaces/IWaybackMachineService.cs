using System;
using System.Threading.Tasks;
using WaybackMachine.Sdk.Models;

namespace WaybackMachine.Sdk.Interfaces
{
    public interface IWaybackMachineService
    {
        Task<Snapshot> GetMostRecentSnapshotAsync(string url);
        Task<Snapshot> GetSnapshotClosestToDateAsync(string url, DateTime date);
        Task<bool> HasSnapshot(string url);
    }
}