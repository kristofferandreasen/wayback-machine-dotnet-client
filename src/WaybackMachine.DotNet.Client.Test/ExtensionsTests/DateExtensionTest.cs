using System;
using WaybackMachine.DotNet.Client.Extensions;
using Xunit;

namespace WaybackMachine.DotNet.Client.Test.ExtensionsTests
{
    public class DateExtensionTest
    {
        [Fact]
        public void Date_extensions_returns_correct_format()
        {
            var date = DateTime.Now;
            var waybackDate = date.ToWaybackMachineDate();

            Assert.Equal(waybackDate[..4], date.Year.ToString());
        }
    }
}