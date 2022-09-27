using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Files
{
    [Table(TableName.PICTURE, Schema = "dbo")]
    public class Picture : BaseEntity
    {
        [Column(TypeName="varbinary(max)")]
        public byte[]? BinaryData { get; set; }
        public string MimeType { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string FileName { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? DirectoryPath { get; set; }
        [ForeignKey(TableName.USER)]
        public int UserId { get; set; }

    }
}
