using System;
using WaybackMachine.Sdk.Extensions;
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
    }
}
