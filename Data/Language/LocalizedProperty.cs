using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Language
{
    [Table(TableName.LOCALIZED_PROPERTY, Schema = "dbo")]
    public class LocalizedProperty : BaseEntity
    {
        public int EntityId { get; set; }
        [ForeignKey(TableName.LANGUAGE)]
        public int LanguageId { get; set; }
        // Table Name
        public string LocalKeyGroup { get; set; }
        // Column Name
        public string LocalKey { get; set; }
        public string LocalValue { get; set; }
        public Language? Language { get; set; }
    }
}
