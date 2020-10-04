using System;
using System.Threading.Tasks;
using WaybackMachine.DotNet.Client.Models;

namespace WaybackMachine.DotNet.Client.Interfaces
{
    public interface IWaybackMachineService
    {
        Task<Snapshot> GetMostRecentSnapshotAsync(string url);
        Task<Snapshot> GetSnapshotClosestToDateAsync(string url, DateTime date);
        Task<bool> HasSnapshot(string url);
    }
}