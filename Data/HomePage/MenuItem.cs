using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.HomePage
{
    [Table(TableName.MENU_ITEM, Schema = "dbo")]
    public class MenuItem : BaseEntity
    {
        public string Name { get; set; }
        public string? DisplayText { get; set; }
        public int DisplayOrder { get; set; }
        public bool Published { get; set; }
        public int? ParentMenuId { get; set; }
        public bool HasSubMenu { get; set; }
        public string? Url{ get; set; }
    }
}
