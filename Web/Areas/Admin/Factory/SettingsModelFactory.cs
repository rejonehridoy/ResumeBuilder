using Core.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.Areas.Admin.Factory
{
    public class SettingsModelFactory : ISettingsModelFactory
    {

        #region Methods

        
        public async Task<List<SelectListItem>> PreparePassowrdFormatTypeItemsAsync()
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem {Text = "Plain Text First", Value = ((int)PasswordFormatType.PlainTextFirst).ToString()},
                new SelectListItem {Text = "Hash First", Value = ((int)PasswordFormatType.HashFirst).ToString()},
                
            };
            return await Task.FromResult(list);
        }

        public async Task<List<SelectListItem>> PrepareCachingPriorityItemsAsync()
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem {Text = "Normal", Value = ((int)CachingPriority.Normal).ToString()},
                new SelectListItem {Text = "Low", Value = ((int)CachingPriority.Low).ToString()},
                new SelectListItem {Text = "High", Value = ((int)CachingPriority.High).ToString()},
                new SelectListItem {Text = "Nerver Remove", Value = ((int)CachingPriority.NeverRemove).ToString()},

            };
            return await Task.FromResult(list);
        }
        #endregion
    }
}
