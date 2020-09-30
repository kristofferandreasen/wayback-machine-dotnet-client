using System;
using Xunit;

namespace WaybackMachine.Sdk.Test
{
    public class WaybackMachineApiTests
    {
        private readonly WaybackMachineService _waybackMachineService;

        public WaybackMachineApiTests()
        {
            _waybackMachineService = new WaybackMachineService();
        }

        [Fact]
        public async void Test1()
        {
            var result = await _waybackMachineService.GetMostRecentSnapshotAsync("google.com");

            Assert.NotNull(result);
        }
    }
}
