using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using WaybackMachine.DotNet.Client.Interfaces;

namespace AzureFunction.Example
{
    public class GetSnapshotFunction
    {
        private readonly IWaybackMachineService _waybackMachineService;

        public GetSnapshotFunction(IWaybackMachineService waybackMachineService)
        {
            _waybackMachineService = waybackMachineService;
        }

        [FunctionName(nameof(GetSnapshotFunction))]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string url = req.Query["url"];

            var snapshot = await _waybackMachineService.GetMostRecentSnapshotAsync(url);

            return snapshot != null
                ? (ActionResult)new OkObjectResult(snapshot)
                : new BadRequestObjectResult("Please pass a url on the query string or in the request body");
        }
    }
}
