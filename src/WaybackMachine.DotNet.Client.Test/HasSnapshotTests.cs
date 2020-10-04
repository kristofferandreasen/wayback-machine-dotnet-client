using Xunit;

namespace WaybackMachine.DotNet.Client.Test
{
    public class HasSnapshotTests
    {
        private readonly WaybackMachineService _waybackMachineService;

        public HasSnapshotTests()
        {
            _waybackMachineService = new WaybackMachineService();
        }

        [Fact]
        public async void Snapshot_is_available_for_website()
        {
            bool snapshotIsAvailable = await _waybackMachineService.HasSnapshot("google.com");

            Assert.True(snapshotIsAvailable);
        }

        [Fact]
        public async void Snapshot_is_not_available_for_website()
        {
            bool snapshotIsAvailable = await _waybackMachineService.HasSnapshot("awdawd//**");

            Assert.False(snapshotIsAvailable);
        }
    }
}