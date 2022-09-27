
using Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.SchedulesTasks
{
    [Table(TableName.SCHEDULE_TASK, Schema = "dbo")]
    public class ScheduleTask : BaseEntity
    {
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        public string? Type { get; set; }
        public bool Enabled { get; set; }
        public int Seconds { get; set; }
        public DateTime? LastStartDate { get; set; }
        public DateTime? LastEndDate { get; set; }
        public DateTime? LastSuccess { get; set; }
        public bool StopOnError { get; set; }
        
    }
}
