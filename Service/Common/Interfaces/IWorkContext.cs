using Microsoft.AspNetCore.Mvc.Rendering;

namespace Service.Common.Interfaces
{
    public  interface IWorkContext
    {
        string GetCurrentClientIpAddress();
        List<SelectListItem> GetAllTimeZones();
        DateTime GetConvertedStoreTime(DateTime utcTime);
    }
}
