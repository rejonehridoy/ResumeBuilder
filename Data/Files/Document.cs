
using Core;
using Data.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Files
{
    [Table(TableName.DOCUMENT, Schema = "dbo")]
    public class Document : BaseEntity
    {
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }
        public string FileName { get; set; }
        public string? DirectoryPath { get; set; }
        public DateTime CreatedDate { get; set; }
        public User? User { get; set; }
    }
}
