using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.FeatureManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikeSharingUi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IFeatureManager _feature;

        public bool InMemoryEnabled { get; set; }
        public bool ApiParksEnabled { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IFeatureManager feature)
        {
            _logger = logger;
            _feature = feature;
        }

        public async Task OnGetAsync()
        {
            InMemoryEnabled = await _feature.IsEnabledAsync("parks-in-memory");
            ApiParksEnabled = await _feature.IsEnabledAsync("parks-api");
        }
    }
}
