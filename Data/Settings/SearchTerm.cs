using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Settings
{
    [Table(TableName.SEARCH_TERM, Schema = "dbo")]
    public class SearchTerm : BaseEntity
    {
        public string Keyword { get; set; }
        public int Count { get; set; }
    }
}
