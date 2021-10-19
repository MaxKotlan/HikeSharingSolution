using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HikeSharingUi.Models;
using HikeSharingUi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement.Mvc;

namespace HikeSharingUi.Pages
{
    [FeatureGate("parks-api")]
    public class ParksApiModel : PageModel
    {
        private readonly IParkApiService _service;

        public ParksApiModel(IParkApiService service)
        {
            _service = service;
        }

        public List<ParkListItemModel> Parks { get; set; }

        public async Task OnGetAsync()
        {
            Parks = await _service.GetAllParksAsync();
        }
    }
}
