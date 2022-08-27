using Microsoft.AspNetCore.Mvc.Razor;

namespace Web.Areas.Admin
{
    public class AdminViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context.Values.TryGetValue("KEY", out string theme))
            {
                if (!string.IsNullOrEmpty(theme) &&  theme.Equals("Admin"))
                {
                    viewLocations = new[] {
                                $"/Areas/Admin/Views/{{1}}/{{0}}.cshtml",
                                $"/Areas/Admin/Views/Shared/{{0}}.cshtml",
                            }
                            .Concat(viewLocations);
                }

            }
            return viewLocations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            if (context.AreaName?.Equals("Admin") ?? false)
                context.Values["KEY"] = "Admin";
        }
    }
}
