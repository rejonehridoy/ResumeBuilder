

using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Settings
{
    [Table(TableName.SETTINGS, Schema = "dbo")]
    public class Setting : BaseEntity
    {
        public string Name { get; set; }
        public string? Value { get; set; }
    }
}
