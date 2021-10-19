using HikeSharingUi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HikeSharingUi.Services
{
    public interface IParkApiService
    {
        Task<List<ParkListItemModel>> GetAllParksAsync();

    }
}