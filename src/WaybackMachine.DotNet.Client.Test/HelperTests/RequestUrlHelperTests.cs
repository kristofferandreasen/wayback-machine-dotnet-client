using System;
using WaybackMachine.DotNet.Client.Helpers;
using Xunit;

namespace WaybackMachine.DotNet.Client.Test.HelperTests
{
    public class RequestUrlHelperTests
    {
        [Fact]
        public void Request_url_returns_correct_format()
        {
            var expectedUrl = "?url=google.com";
            var requestUrl = RequestUrlHelpers.ConstructRequest("google.com");

            Assert.Equal(expectedUrl, requestUrl);
        }

        [Fact]
        public void Request_url_returns_correct_format_with_timestamp()
        {
            var expectedUrl = "?url=google.com&timestamp=20201001000000";
            var requestUrl = RequestUrlHelpers.ConstructRequestWithTimestamp("google.com", new DateTime(2020, 10, 01));

            Assert.Equal(expectedUrl, requestUrl);
        }
    }
}