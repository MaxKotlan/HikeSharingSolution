using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HikeSharingUi.Models;
using HikeSharingUi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HikeSharingUi.Pages
{
    public class ParksModel : PageModel
    {
        private readonly IParkService _parks;

        public ParksModel(IParkService parks)
        {
            _parks = parks;
        }

        public List<ParkListItemModel> Model { get; set; }

        public async void OnGetAsync()
        {
            Model = await _parks.GetAllParksAsync();
        }
    }
}
