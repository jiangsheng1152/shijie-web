using DailyDaGang.Core;
using SqlSugar;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DailyDaGang.Entities
{
    [SugarTable]
    public class DailyEntity:EntityBase
    {
        [DisplayName("内容")]
        [Required]
        public string? Content { set; get; }

        public DateTime CreateDate { set; get; }

        [SugarColumn(DefaultValue ="0")]
        public long JumpNum { set; get; }
    }
}
