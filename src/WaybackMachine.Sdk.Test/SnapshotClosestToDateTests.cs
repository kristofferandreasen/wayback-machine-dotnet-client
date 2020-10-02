using System;
using WaybackMachine.Sdk.Models;
using Xunit;

namespace WaybackMachine.Sdk.Test
{
    public class SnapshotClosestToDateTests
    {
        private readonly WaybackMachineService _waybackMachineService;

        public SnapshotClosestToDateTests()
        {
            _waybackMachineService = new WaybackMachineService();
        }

        [Fact]
        public async void Service_returns_snapshot_from_date()
        {
            DateTime today = DateTime.Now;
            Snapshot snapshot = await _waybackMachineService.GetSnapshotClosestToDateAsync("google.com", today);

            Assert.NotNull(snapshot);
        }

        [Fact]
        public async void Service_returns_snapshot_from_older_date()
        {
            DateTime dateTime = new DateTime(2016, 7, 15, 3, 15, 0); 
            Snapshot snapshot = await _waybackMachineService.GetSnapshotClosestToDateAsync("google.com", dateTime);

            Assert.NotNull(snapshot);
            Assert.Equal(dateTime.Year, snapshot.ArchivedSnapshots.Closest.Timestamp.Year);
        }
    }
}