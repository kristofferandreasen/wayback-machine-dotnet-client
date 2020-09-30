using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaybackMachine.Sdk.Models;

namespace WaybackMachine.Sdk.Interfaces
{
    public interface IWaybackMachineService
    {
        public Task<Snapshot> GetMostRecentSnapshotAsync(string url);
        public Task<Snapshot> GetSnapshotsClosestToDateAsync(DateTime date);
        public Task<List<Snapshot>> GetSnapshotsFromTodayAsync(DateTime date);
        public Task<List<Snapshot>> GetSnapshotsFromCurrentMonthAsync(DateTime date);
        public Task<List<Snapshot>> GetSnapshotsFromCurrentWeekAsync(DateTime date);
        public Task<List<Snapshot>> GetSnapshotsBeforeDateAsync(DateTime date);
        public Task<bool> WebsiteHasSnapshots(string url);
    }
}