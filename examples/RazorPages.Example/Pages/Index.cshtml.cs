using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPages.Example.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWaybackMachineService _waybackMachineService;

        public IndexModel(
            ILogger<IndexModel> logger,
            IWaybackMachineService waybackMachineService
        )
        {
            _logger = logger;
            _waybackMachineService = waybackMachineService;
        }

        public void OnGet()
        {
            
        }
    }
}
