using Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace Data.HomePage
{
    [Table(TableName.TOPIC, Schema = "dbo")]
    public class Topic : BaseEntity
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string? Text { get; set; }
        public string? Icons { get; set; }
        public bool Published{ get; set; }
        public DateTime CreatedDate{ get; set; }
        public int DisplayOrder{ get; set; }
    }
}
