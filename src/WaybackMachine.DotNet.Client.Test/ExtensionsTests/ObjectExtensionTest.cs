using WaybackMachine.DotNet.Client.Extensions;
using WaybackMachine.DotNet.Client.Models;
using Xunit;

namespace WaybackMachine.DotNet.Client.Test.ExtensionsTests
{
    public class ObjectExtensionTest
    {
        [Fact]
        public void Object_extensions_returns_correct_result()
        {
            var snapshotObject = new Snapshot 
            {
                Url = "google.com"
            };

            bool hasArchivedSnapshots = snapshotObject.HasProperty(nameof(ArchivedSnapshots));

            Assert.True(hasArchivedSnapshots);
            Assert.Null(snapshotObject.ArchivedSnapshots);
        }
    }
}