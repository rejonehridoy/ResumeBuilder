﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.Factory
{
    public interface ISettingsModelFactory
    {
        Task<List<SelectListItem>> PrepareTimeZonesList();
    }
}
