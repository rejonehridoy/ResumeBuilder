using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Files
{
    [Table(TableName.PICTURE, Schema = "dbo")]
    public class Picture : BaseEntity
    {
        [Column(TypeName="varbinary(max)")]
        public byte[]? BinaryData { get; set; }
        public int? MimeType { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string FileName { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? DirectoryPath { get; set; }

    }
}
